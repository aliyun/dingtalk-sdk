// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCorrectStyleResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCorrectStyleResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetCorrectStyleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorrectStyleResponseBody self = new GetCorrectStyleResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorrectStyleResponseBody setResult(GetCorrectStyleResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCorrectStyleResponseBodyResult getResult() {
        return this.result;
    }

    public GetCorrectStyleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetCorrectStyleResponseBodyResult extends TeaModel {
        @NameInMap("checkSizeType")
        public String checkSizeType;

        @NameInMap("halfCheckSizeType")
        public String halfCheckSizeType;

        @NameInMap("showPaperScore")
        public Boolean showPaperScore;

        @NameInMap("subScoreDisplayType")
        public String subScoreDisplayType;

        @NameInMap("wrongSizeType")
        public String wrongSizeType;

        @NameInMap("wrongStyle")
        public String wrongStyle;

        public static GetCorrectStyleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCorrectStyleResponseBodyResult self = new GetCorrectStyleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCorrectStyleResponseBodyResult setCheckSizeType(String checkSizeType) {
            this.checkSizeType = checkSizeType;
            return this;
        }
        public String getCheckSizeType() {
            return this.checkSizeType;
        }

        public GetCorrectStyleResponseBodyResult setHalfCheckSizeType(String halfCheckSizeType) {
            this.halfCheckSizeType = halfCheckSizeType;
            return this;
        }
        public String getHalfCheckSizeType() {
            return this.halfCheckSizeType;
        }

        public GetCorrectStyleResponseBodyResult setShowPaperScore(Boolean showPaperScore) {
            this.showPaperScore = showPaperScore;
            return this;
        }
        public Boolean getShowPaperScore() {
            return this.showPaperScore;
        }

        public GetCorrectStyleResponseBodyResult setSubScoreDisplayType(String subScoreDisplayType) {
            this.subScoreDisplayType = subScoreDisplayType;
            return this;
        }
        public String getSubScoreDisplayType() {
            return this.subScoreDisplayType;
        }

        public GetCorrectStyleResponseBodyResult setWrongSizeType(String wrongSizeType) {
            this.wrongSizeType = wrongSizeType;
            return this;
        }
        public String getWrongSizeType() {
            return this.wrongSizeType;
        }

        public GetCorrectStyleResponseBodyResult setWrongStyle(String wrongStyle) {
            this.wrongStyle = wrongStyle;
            return this;
        }
        public String getWrongStyle() {
            return this.wrongStyle;
        }

    }

}
