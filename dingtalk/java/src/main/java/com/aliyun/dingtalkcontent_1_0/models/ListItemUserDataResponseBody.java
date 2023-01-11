// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class ListItemUserDataResponseBody extends TeaModel {
    /**
     * <p>学习的时长记录</p>
     */
    @NameInMap("studyInfos")
    public java.util.List<ListItemUserDataResponseBodyStudyInfos> studyInfos;

    public static ListItemUserDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListItemUserDataResponseBody self = new ListItemUserDataResponseBody();
        return TeaModel.build(map, self);
    }

    public ListItemUserDataResponseBody setStudyInfos(java.util.List<ListItemUserDataResponseBodyStudyInfos> studyInfos) {
        this.studyInfos = studyInfos;
        return this;
    }
    public java.util.List<ListItemUserDataResponseBodyStudyInfos> getStudyInfos() {
        return this.studyInfos;
    }

    public static class ListItemUserDataResponseBodyStudyInfos extends TeaModel {
        /**
         * <p>时间持续长度，单位为毫秒</p>
         */
        @NameInMap("durationMillis")
        public Long durationMillis;

        /**
         * <p>用户id</p>
         */
        @NameInMap("uid")
        public String uid;

        public static ListItemUserDataResponseBodyStudyInfos build(java.util.Map<String, ?> map) throws Exception {
            ListItemUserDataResponseBodyStudyInfos self = new ListItemUserDataResponseBodyStudyInfos();
            return TeaModel.build(map, self);
        }

        public ListItemUserDataResponseBodyStudyInfos setDurationMillis(Long durationMillis) {
            this.durationMillis = durationMillis;
            return this;
        }
        public Long getDurationMillis() {
            return this.durationMillis;
        }

        public ListItemUserDataResponseBodyStudyInfos setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

    }

}
