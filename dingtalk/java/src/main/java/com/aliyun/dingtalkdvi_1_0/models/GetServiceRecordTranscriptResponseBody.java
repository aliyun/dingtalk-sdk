// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceRecordTranscriptResponseBody extends TeaModel {
    @NameInMap("result")
    public GetServiceRecordTranscriptResponseBodyResult result;

    public static GetServiceRecordTranscriptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetServiceRecordTranscriptResponseBody self = new GetServiceRecordTranscriptResponseBody();
        return TeaModel.build(map, self);
    }

    public GetServiceRecordTranscriptResponseBody setResult(GetServiceRecordTranscriptResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetServiceRecordTranscriptResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetServiceRecordTranscriptResponseBodyResultAudionTextDataList extends TeaModel {
        @NameInMap("channel")
        public String channel;

        @NameInMap("endTime")
        public String endTime;

        @NameInMap("startTime")
        public String startTime;

        @NameInMap("text")
        public String text;

        public static GetServiceRecordTranscriptResponseBodyResultAudionTextDataList build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordTranscriptResponseBodyResultAudionTextDataList self = new GetServiceRecordTranscriptResponseBodyResultAudionTextDataList();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordTranscriptResponseBodyResultAudionTextDataList setChannel(String channel) {
            this.channel = channel;
            return this;
        }
        public String getChannel() {
            return this.channel;
        }

        public GetServiceRecordTranscriptResponseBodyResultAudionTextDataList setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public GetServiceRecordTranscriptResponseBodyResultAudionTextDataList setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

        public GetServiceRecordTranscriptResponseBodyResultAudionTextDataList setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class GetServiceRecordTranscriptResponseBodyResultAudionText extends TeaModel {
        @NameInMap("dataList")
        public java.util.List<GetServiceRecordTranscriptResponseBodyResultAudionTextDataList> dataList;

        @NameInMap("status")
        public String status;

        public static GetServiceRecordTranscriptResponseBodyResultAudionText build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordTranscriptResponseBodyResultAudionText self = new GetServiceRecordTranscriptResponseBodyResultAudionText();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordTranscriptResponseBodyResultAudionText setDataList(java.util.List<GetServiceRecordTranscriptResponseBodyResultAudionTextDataList> dataList) {
            this.dataList = dataList;
            return this;
        }
        public java.util.List<GetServiceRecordTranscriptResponseBodyResultAudionTextDataList> getDataList() {
            return this.dataList;
        }

        public GetServiceRecordTranscriptResponseBodyResultAudionText setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class GetServiceRecordTranscriptResponseBodyResultSpeakerDataList extends TeaModel {
        @NameInMap("channel")
        public String channel;

        @NameInMap("role")
        public String role;

        public static GetServiceRecordTranscriptResponseBodyResultSpeakerDataList build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordTranscriptResponseBodyResultSpeakerDataList self = new GetServiceRecordTranscriptResponseBodyResultSpeakerDataList();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordTranscriptResponseBodyResultSpeakerDataList setChannel(String channel) {
            this.channel = channel;
            return this;
        }
        public String getChannel() {
            return this.channel;
        }

        public GetServiceRecordTranscriptResponseBodyResultSpeakerDataList setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

    }

    public static class GetServiceRecordTranscriptResponseBodyResultSpeaker extends TeaModel {
        @NameInMap("dataList")
        public java.util.List<GetServiceRecordTranscriptResponseBodyResultSpeakerDataList> dataList;

        @NameInMap("status")
        public String status;

        public static GetServiceRecordTranscriptResponseBodyResultSpeaker build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordTranscriptResponseBodyResultSpeaker self = new GetServiceRecordTranscriptResponseBodyResultSpeaker();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordTranscriptResponseBodyResultSpeaker setDataList(java.util.List<GetServiceRecordTranscriptResponseBodyResultSpeakerDataList> dataList) {
            this.dataList = dataList;
            return this;
        }
        public java.util.List<GetServiceRecordTranscriptResponseBodyResultSpeakerDataList> getDataList() {
            return this.dataList;
        }

        public GetServiceRecordTranscriptResponseBodyResultSpeaker setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class GetServiceRecordTranscriptResponseBodyResult extends TeaModel {
        @NameInMap("audionText")
        public GetServiceRecordTranscriptResponseBodyResultAudionText audionText;

        @NameInMap("speaker")
        public GetServiceRecordTranscriptResponseBodyResultSpeaker speaker;

        public static GetServiceRecordTranscriptResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRecordTranscriptResponseBodyResult self = new GetServiceRecordTranscriptResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetServiceRecordTranscriptResponseBodyResult setAudionText(GetServiceRecordTranscriptResponseBodyResultAudionText audionText) {
            this.audionText = audionText;
            return this;
        }
        public GetServiceRecordTranscriptResponseBodyResultAudionText getAudionText() {
            return this.audionText;
        }

        public GetServiceRecordTranscriptResponseBodyResult setSpeaker(GetServiceRecordTranscriptResponseBodyResultSpeaker speaker) {
            this.speaker = speaker;
            return this;
        }
        public GetServiceRecordTranscriptResponseBodyResultSpeaker getSpeaker() {
            return this.speaker;
        }

    }

}
