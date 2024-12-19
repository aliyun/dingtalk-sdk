// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddLiveNoticeWidgetResponseBody extends TeaModel {
    @NameInMap("result")
    public AddLiveNoticeWidgetResponseBodyResult result;

    public static AddLiveNoticeWidgetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddLiveNoticeWidgetResponseBody self = new AddLiveNoticeWidgetResponseBody();
        return TeaModel.build(map, self);
    }

    public AddLiveNoticeWidgetResponseBody setResult(AddLiveNoticeWidgetResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddLiveNoticeWidgetResponseBodyResult getResult() {
        return this.result;
    }

    public static class AddLiveNoticeWidgetResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static AddLiveNoticeWidgetResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddLiveNoticeWidgetResponseBodyResult self = new AddLiveNoticeWidgetResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddLiveNoticeWidgetResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
