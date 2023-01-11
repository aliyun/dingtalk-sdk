// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EndCourseRequest extends TeaModel {
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
     * <p>isv编码</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <p>直播流信息</p>
     */
    @NameInMap("livePlayInfoList")
    public java.util.List<EndCourseRequestLivePlayInfoList> livePlayInfoList;

    /**
     * <p>用户id</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static EndCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        EndCourseRequest self = new EndCourseRequest();
        return TeaModel.build(map, self);
    }

    public EndCourseRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public EndCourseRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public EndCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public EndCourseRequest setLivePlayInfoList(java.util.List<EndCourseRequestLivePlayInfoList> livePlayInfoList) {
        this.livePlayInfoList = livePlayInfoList;
        return this;
    }
    public java.util.List<EndCourseRequestLivePlayInfoList> getLivePlayInfoList() {
        return this.livePlayInfoList;
    }

    public EndCourseRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class EndCourseRequestLivePlayInfoList extends TeaModel {
        /**
         * <p>直播推流地址</p>
         */
        @NameInMap("liveInputUrl")
        public String liveInputUrl;

        /**
         * <p>Flv直播拉回地址</p>
         */
        @NameInMap("liveOutputFlvUrl")
        public String liveOutputFlvUrl;

        /**
         * <p>Hls直播拉流地址</p>
         */
        @NameInMap("liveOutputHlsUrl")
        public String liveOutputHlsUrl;

        /**
         * <p>直播流类型</p>
         */
        @NameInMap("liveType")
        public Integer liveType;

        /**
         * <p>回放视频地址</p>
         */
        @NameInMap("replayUrl")
        public String replayUrl;

        public static EndCourseRequestLivePlayInfoList build(java.util.Map<String, ?> map) throws Exception {
            EndCourseRequestLivePlayInfoList self = new EndCourseRequestLivePlayInfoList();
            return TeaModel.build(map, self);
        }

        public EndCourseRequestLivePlayInfoList setLiveInputUrl(String liveInputUrl) {
            this.liveInputUrl = liveInputUrl;
            return this;
        }
        public String getLiveInputUrl() {
            return this.liveInputUrl;
        }

        public EndCourseRequestLivePlayInfoList setLiveOutputFlvUrl(String liveOutputFlvUrl) {
            this.liveOutputFlvUrl = liveOutputFlvUrl;
            return this;
        }
        public String getLiveOutputFlvUrl() {
            return this.liveOutputFlvUrl;
        }

        public EndCourseRequestLivePlayInfoList setLiveOutputHlsUrl(String liveOutputHlsUrl) {
            this.liveOutputHlsUrl = liveOutputHlsUrl;
            return this;
        }
        public String getLiveOutputHlsUrl() {
            return this.liveOutputHlsUrl;
        }

        public EndCourseRequestLivePlayInfoList setLiveType(Integer liveType) {
            this.liveType = liveType;
            return this;
        }
        public Integer getLiveType() {
            return this.liveType;
        }

        public EndCourseRequestLivePlayInfoList setReplayUrl(String replayUrl) {
            this.replayUrl = replayUrl;
            return this;
        }
        public String getReplayUrl() {
            return this.replayUrl;
        }

    }

}
