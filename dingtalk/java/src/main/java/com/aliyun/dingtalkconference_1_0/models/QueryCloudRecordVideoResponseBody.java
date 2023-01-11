// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoResponseBody extends TeaModel {
    /**
     * <p>视频列表</p>
     */
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
        /**
         * <p>录制持续时间</p>
         */
        @NameInMap("duration")
        public Long duration;

        /**
         * <p>录制结束时间</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>文件大小</p>
         */
        @NameInMap("fileSize")
        public Long fileSize;

        /**
         * <p>媒体文件id，唯一</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <p>音视频云录制Id，多份视频recordId一样</p>
         */
        @NameInMap("recordId")
        public String recordId;

        /**
         * <p>记录类型,0-普通录制，1-合成的文件</p>
         */
        @NameInMap("recordType")
        public Long recordType;

        /**
         * <p>媒体文件所在集群id</p>
         */
        @NameInMap("regionId")
        public String regionId;

        /**
         * <p>录制开始时间</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>录制人UnionId</p>
         */
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
