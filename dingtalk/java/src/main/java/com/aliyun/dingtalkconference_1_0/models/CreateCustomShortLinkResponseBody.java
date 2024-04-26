// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomShortLinkResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateCustomShortLinkResponseBodyResult result;

    public static CreateCustomShortLinkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomShortLinkResponseBody self = new CreateCustomShortLinkResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomShortLinkResponseBody setResult(CreateCustomShortLinkResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateCustomShortLinkResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateCustomShortLinkResponseBodyResult extends TeaModel {
        @NameInMap("customShortLink")
        public String customShortLink;

        public static CreateCustomShortLinkResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomShortLinkResponseBodyResult self = new CreateCustomShortLinkResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateCustomShortLinkResponseBodyResult setCustomShortLink(String customShortLink) {
            this.customShortLink = customShortLink;
            return this;
        }
        public String getCustomShortLink() {
            return this.customShortLink;
        }

    }

}
