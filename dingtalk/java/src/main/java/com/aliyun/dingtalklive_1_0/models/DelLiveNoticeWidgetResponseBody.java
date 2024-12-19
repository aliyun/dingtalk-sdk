// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DelLiveNoticeWidgetResponseBody extends TeaModel {
    @NameInMap("result")
    public DelLiveNoticeWidgetResponseBodyResult result;

    public static DelLiveNoticeWidgetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DelLiveNoticeWidgetResponseBody self = new DelLiveNoticeWidgetResponseBody();
        return TeaModel.build(map, self);
    }

    public DelLiveNoticeWidgetResponseBody setResult(DelLiveNoticeWidgetResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DelLiveNoticeWidgetResponseBodyResult getResult() {
        return this.result;
    }

    public static class DelLiveNoticeWidgetResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static DelLiveNoticeWidgetResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DelLiveNoticeWidgetResponseBodyResult self = new DelLiveNoticeWidgetResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DelLiveNoticeWidgetResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
