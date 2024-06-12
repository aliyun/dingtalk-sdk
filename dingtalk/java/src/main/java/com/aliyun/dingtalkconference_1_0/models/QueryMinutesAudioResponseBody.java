// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesAudioResponseBody extends TeaModel {
    @NameInMap("audioList")
    public java.util.List<QueryMinutesAudioResponseBodyAudioList> audioList;

    public static QueryMinutesAudioResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesAudioResponseBody self = new QueryMinutesAudioResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesAudioResponseBody setAudioList(java.util.List<QueryMinutesAudioResponseBodyAudioList> audioList) {
        this.audioList = audioList;
        return this;
    }
    public java.util.List<QueryMinutesAudioResponseBodyAudioList> getAudioList() {
        return this.audioList;
    }

    public static class QueryMinutesAudioResponseBodyAudioList extends TeaModel {
        @NameInMap("duration")
        public Long duration;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("playUrl")
        public String playUrl;

        @NameInMap("recordId")
        public String recordId;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("unionId")
        public String unionId;

        public static QueryMinutesAudioResponseBodyAudioList build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesAudioResponseBodyAudioList self = new QueryMinutesAudioResponseBodyAudioList();
            return TeaModel.build(map, self);
        }

        public QueryMinutesAudioResponseBodyAudioList setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryMinutesAudioResponseBodyAudioList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryMinutesAudioResponseBodyAudioList setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public QueryMinutesAudioResponseBodyAudioList setPlayUrl(String playUrl) {
            this.playUrl = playUrl;
            return this;
        }
        public String getPlayUrl() {
            return this.playUrl;
        }

        public QueryMinutesAudioResponseBodyAudioList setRecordId(String recordId) {
            this.recordId = recordId;
            return this;
        }
        public String getRecordId() {
            return this.recordId;
        }

        public QueryMinutesAudioResponseBodyAudioList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryMinutesAudioResponseBodyAudioList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
