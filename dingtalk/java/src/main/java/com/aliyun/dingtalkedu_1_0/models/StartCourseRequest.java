// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCourseRequest extends TeaModel {
    /**
     * <p>课程编码</p>
     */
    @NameInMap("courseCode")
    public String courseCode;

    /**
     * <p>拓展字段</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <p>isvCode</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <p>livePlayInfoList</p>
     */
    @NameInMap("livePlayInfoList")
    public java.util.List<StartCourseRequestLivePlayInfoList> livePlayInfoList;

    /**
     * <p>opUserId</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static StartCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        StartCourseRequest self = new StartCourseRequest();
        return TeaModel.build(map, self);
    }

    public StartCourseRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public StartCourseRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public StartCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public StartCourseRequest setLivePlayInfoList(java.util.List<StartCourseRequestLivePlayInfoList> livePlayInfoList) {
        this.livePlayInfoList = livePlayInfoList;
        return this;
    }
    public java.util.List<StartCourseRequestLivePlayInfoList> getLivePlayInfoList() {
        return this.livePlayInfoList;
    }

    public StartCourseRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class StartCourseRequestLivePlayInfoList extends TeaModel {
        /**
         * <p>直播推流地址</p>
         */
        @NameInMap("liveInputUrl")
        public String liveInputUrl;

        /**
         * <p>Flv格式直播地址</p>
         */
        @NameInMap("liveOutputFlvUrl")
        public String liveOutputFlvUrl;

        /**
         * <p>Hls格式直播拉流地址</p>
         */
        @NameInMap("liveOutputHlsUrl")
        public String liveOutputHlsUrl;

        /**
         * <p>直播流类型</p>
         */
        @NameInMap("liveType")
        public Integer liveType;

        /**
         * <p>视频回放地址</p>
         */
        @NameInMap("replayUrl")
        public String replayUrl;

        public static StartCourseRequestLivePlayInfoList build(java.util.Map<String, ?> map) throws Exception {
            StartCourseRequestLivePlayInfoList self = new StartCourseRequestLivePlayInfoList();
            return TeaModel.build(map, self);
        }

        public StartCourseRequestLivePlayInfoList setLiveInputUrl(String liveInputUrl) {
            this.liveInputUrl = liveInputUrl;
            return this;
        }
        public String getLiveInputUrl() {
            return this.liveInputUrl;
        }

        public StartCourseRequestLivePlayInfoList setLiveOutputFlvUrl(String liveOutputFlvUrl) {
            this.liveOutputFlvUrl = liveOutputFlvUrl;
            return this;
        }
        public String getLiveOutputFlvUrl() {
            return this.liveOutputFlvUrl;
        }

        public StartCourseRequestLivePlayInfoList setLiveOutputHlsUrl(String liveOutputHlsUrl) {
            this.liveOutputHlsUrl = liveOutputHlsUrl;
            return this;
        }
        public String getLiveOutputHlsUrl() {
            return this.liveOutputHlsUrl;
        }

        public StartCourseRequestLivePlayInfoList setLiveType(Integer liveType) {
            this.liveType = liveType;
            return this;
        }
        public Integer getLiveType() {
            return this.liveType;
        }

        public StartCourseRequestLivePlayInfoList setReplayUrl(String replayUrl) {
            this.replayUrl = replayUrl;
            return this;
        }
        public String getReplayUrl() {
            return this.replayUrl;
        }

    }

}
