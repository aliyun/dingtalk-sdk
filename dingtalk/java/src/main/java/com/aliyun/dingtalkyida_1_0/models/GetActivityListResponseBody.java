// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivityListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetActivityListResponseBodyResult> result;

    public static GetActivityListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetActivityListResponseBody self = new GetActivityListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetActivityListResponseBody setResult(java.util.List<GetActivityListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetActivityListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetActivityListResponseBodyResult extends TeaModel {
        @NameInMap("activityId")
        public String activityId;

        @NameInMap("activityName")
        public String activityName;

        @NameInMap("activityNameInEnglish")
        public String activityNameInEnglish;

        public static GetActivityListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetActivityListResponseBodyResult self = new GetActivityListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetActivityListResponseBodyResult setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetActivityListResponseBodyResult setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public GetActivityListResponseBodyResult setActivityNameInEnglish(String activityNameInEnglish) {
            this.activityNameInEnglish = activityNameInEnglish;
            return this;
        }
        public String getActivityNameInEnglish() {
            return this.activityNameInEnglish;
        }

    }

}
