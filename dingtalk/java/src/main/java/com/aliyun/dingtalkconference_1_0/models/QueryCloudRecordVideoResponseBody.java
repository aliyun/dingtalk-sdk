// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoResponseBody extends TeaModel {
    @NameInMap("videoList")
    public java.util.List<QueryCloudRecordVideoResponseBodyVideoList> videoList;

    public static QueryCloudRecordVideoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordVideoResponseBody self = new QueryCloudRecordVideoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordVideoResponseBody setVideoList(java.util.List<QueryCloudRecordVideoResponseBodyVideoList> videoList) {
        this.videoList = videoList;
        return this;
    }
    public java.util.List<QueryCloudRecordVideoResponseBodyVideoList> getVideoList() {
        return this.videoList;
    }

    public static class QueryCloudRecordVideoResponseBodyVideoList extends TeaModel {
        @NameInMap("duration")
        public Long duration;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("recordId")
        public String recordId;

        @NameInMap("recordType")
        public Long recordType;

        @NameInMap("regionId")
        public String regionId;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("unionId")
        public String unionId;

        public static QueryCloudRecordVideoResponseBodyVideoList build(java.util.Map<String, ?> map) throws Exception {
            QueryCloudRecordVideoResponseBodyVideoList self = new QueryCloudRecordVideoResponseBodyVideoList();
            return TeaModel.build(map, self);
        }

        public QueryCloudRecordVideoResponseBodyVideoList setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setRecordId(String recordId) {
            this.recordId = recordId;
            return this;
        }
        public String getRecordId() {
            return this.recordId;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setRecordType(Long recordType) {
            this.recordType = recordType;
            return this;
        }
        public Long getRecordType() {
            return this.recordType;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setRegionId(String regionId) {
            this.regionId = regionId;
            return this;
        }
        public String getRegionId() {
            return this.regionId;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryCloudRecordVideoResponseBodyVideoList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
