// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivityListResponseBody extends TeaModel {
    // Id of the request
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
        // activityName
        @NameInMap("activityName")
        public String activityName;

        // activityNameEn
        @NameInMap("activityNameInEnglish")
        public String activityNameInEnglish;

        // activityId
        @NameInMap("activityId")
        public String activityId;

        public static GetActivityListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetActivityListResponseBodyResult self = new GetActivityListResponseBodyResult();
            return TeaModel.build(map, self);
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

        public GetActivityListResponseBodyResult setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

    }

}
