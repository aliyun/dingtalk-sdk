// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDocRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public CopyDocRequestParam param;

    public static CopyDocRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyDocRequest self = new CopyDocRequest();
        return TeaModel.build(map, self);
    }

    public CopyDocRequest setParam(CopyDocRequestParam param) {
        this.param = param;
        return this;
    }
    public CopyDocRequestParam getParam() {
        return this.param;
    }

    public static class CopyDocRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("sourceDentryUuid")
        public String sourceDentryUuid;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("targetParentDentryUuid")
        public String targetParentDentryUuid;

        /**
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("targetPreDentryUuid")
        public String targetPreDentryUuid;

        public static CopyDocRequestParam build(java.util.Map<String, ?> map) throws Exception {
            CopyDocRequestParam self = new CopyDocRequestParam();
            return TeaModel.build(map, self);
        }

        public CopyDocRequestParam setSourceDentryUuid(String sourceDentryUuid) {
            this.sourceDentryUuid = sourceDentryUuid;
            return this;
        }
        public String getSourceDentryUuid() {
            return this.sourceDentryUuid;
        }

        public CopyDocRequestParam setTargetParentDentryUuid(String targetParentDentryUuid) {
            this.targetParentDentryUuid = targetParentDentryUuid;
            return this;
        }
        public String getTargetParentDentryUuid() {
            return this.targetParentDentryUuid;
        }

        public CopyDocRequestParam setTargetPreDentryUuid(String targetPreDentryUuid) {
            this.targetPreDentryUuid = targetPreDentryUuid;
            return this;
        }
        public String getTargetPreDentryUuid() {
            return this.targetPreDentryUuid;
        }

    }

}
