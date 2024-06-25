// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveWatchDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryLiveWatchDetailResponseBodyResult result;

    public static QueryLiveWatchDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveWatchDetailResponseBody self = new QueryLiveWatchDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryLiveWatchDetailResponseBody setResult(QueryLiveWatchDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryLiveWatchDetailResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryLiveWatchDetailResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3560</p>
         */
        @NameInMap("avgWatchTime")
        public Long avgWatchTime;

        /**
         * <strong>example:</strong>
         * <p>55</p>
         */
        @NameInMap("liveUv")
        public Integer liveUv;

        /**
         * <strong>example:</strong>
         * <p>252</p>
         */
        @NameInMap("msgCount")
        public Integer msgCount;

        /**
         * <strong>example:</strong>
         * <p>72</p>
         */
        @NameInMap("playbackUv")
        public Integer playbackUv;

        /**
         * <strong>example:</strong>
         * <p>500</p>
         */
        @NameInMap("praiseCount")
        public Integer praiseCount;

        /**
         * <strong>example:</strong>
         * <p>120</p>
         */
        @NameInMap("pv")
        public Integer pv;

        /**
         * <strong>example:</strong>
         * <p>1903640</p>
         */
        @NameInMap("totalWatchTime")
        public Long totalWatchTime;

        /**
         * <strong>example:</strong>
         * <p>90</p>
         */
        @NameInMap("uv")
        public Integer uv;

        public static QueryLiveWatchDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveWatchDetailResponseBodyResult self = new QueryLiveWatchDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryLiveWatchDetailResponseBodyResult setAvgWatchTime(Long avgWatchTime) {
            this.avgWatchTime = avgWatchTime;
            return this;
        }
        public Long getAvgWatchTime() {
            return this.avgWatchTime;
        }

        public QueryLiveWatchDetailResponseBodyResult setLiveUv(Integer liveUv) {
            this.liveUv = liveUv;
            return this;
        }
        public Integer getLiveUv() {
            return this.liveUv;
        }

        public QueryLiveWatchDetailResponseBodyResult setMsgCount(Integer msgCount) {
            this.msgCount = msgCount;
            return this;
        }
        public Integer getMsgCount() {
            return this.msgCount;
        }

        public QueryLiveWatchDetailResponseBodyResult setPlaybackUv(Integer playbackUv) {
            this.playbackUv = playbackUv;
            return this;
        }
        public Integer getPlaybackUv() {
            return this.playbackUv;
        }

        public QueryLiveWatchDetailResponseBodyResult setPraiseCount(Integer praiseCount) {
            this.praiseCount = praiseCount;
            return this;
        }
        public Integer getPraiseCount() {
            return this.praiseCount;
        }

        public QueryLiveWatchDetailResponseBodyResult setPv(Integer pv) {
            this.pv = pv;
            return this;
        }
        public Integer getPv() {
            return this.pv;
        }

        public QueryLiveWatchDetailResponseBodyResult setTotalWatchTime(Long totalWatchTime) {
            this.totalWatchTime = totalWatchTime;
            return this;
        }
        public Long getTotalWatchTime() {
            return this.totalWatchTime;
        }

        public QueryLiveWatchDetailResponseBodyResult setUv(Integer uv) {
            this.uv = uv;
            return this;
        }
        public Integer getUv() {
            return this.uv;
        }

    }

}
