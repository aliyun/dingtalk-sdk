// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ShareUrlRequest extends TeaModel {
    @NameInMap("param")
    public ShareUrlRequestParam param;

    public static ShareUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        ShareUrlRequest self = new ShareUrlRequest();
        return TeaModel.build(map, self);
    }

    public ShareUrlRequest setParam(ShareUrlRequestParam param) {
        this.param = param;
        return this;
    }
    public ShareUrlRequestParam getParam() {
        return this.param;
    }

    public static class ShareUrlRequestParam extends TeaModel {
        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("triggerShare")
        public Boolean triggerShare;

        public static ShareUrlRequestParam build(java.util.Map<String, ?> map) throws Exception {
            ShareUrlRequestParam self = new ShareUrlRequestParam();
            return TeaModel.build(map, self);
        }

        public ShareUrlRequestParam setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public ShareUrlRequestParam setTriggerShare(Boolean triggerShare) {
            this.triggerShare = triggerShare;
            return this;
        }
        public Boolean getTriggerShare() {
            return this.triggerShare;
        }

    }

}
