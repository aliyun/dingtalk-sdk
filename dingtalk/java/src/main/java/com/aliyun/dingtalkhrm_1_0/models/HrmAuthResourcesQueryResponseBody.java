// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmAuthResourcesQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<HrmAuthResourcesQueryResponseBodyResult> result;

    public static HrmAuthResourcesQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmAuthResourcesQueryResponseBody self = new HrmAuthResourcesQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmAuthResourcesQueryResponseBody setResult(java.util.List<HrmAuthResourcesQueryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<HrmAuthResourcesQueryResponseBodyResult> getResult() {
        return this.result;
    }

    public static class HrmAuthResourcesQueryResponseBodyResult extends TeaModel {
        @NameInMap("authorized")
        public Boolean authorized;

        /**
         * <strong>example:</strong>
         * <p>/signSetting/manage/*</p>
         */
        @NameInMap("resourceId")
        public String resourceId;

        public static HrmAuthResourcesQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            HrmAuthResourcesQueryResponseBodyResult self = new HrmAuthResourcesQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public HrmAuthResourcesQueryResponseBodyResult setAuthorized(Boolean authorized) {
            this.authorized = authorized;
            return this;
        }
        public Boolean getAuthorized() {
            return this.authorized;
        }

        public HrmAuthResourcesQueryResponseBodyResult setResourceId(String resourceId) {
            this.resourceId = resourceId;
            return this;
        }
        public String getResourceId() {
            return this.resourceId;
        }

    }

}
