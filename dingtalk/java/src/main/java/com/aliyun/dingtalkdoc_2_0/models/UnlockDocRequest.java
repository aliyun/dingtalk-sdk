// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnlockDocRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public UnlockDocRequestParam param;

    public static UnlockDocRequest build(java.util.Map<String, ?> map) throws Exception {
        UnlockDocRequest self = new UnlockDocRequest();
        return TeaModel.build(map, self);
    }

    public UnlockDocRequest setParam(UnlockDocRequestParam param) {
        this.param = param;
        return this;
    }
    public UnlockDocRequestParam getParam() {
        return this.param;
    }

    public static class UnlockDocRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("dentryUuid")
        public String dentryUuid;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>operatorUid</p>
         */
        @NameInMap("operatorUid")
        public String operatorUid;

        public static UnlockDocRequestParam build(java.util.Map<String, ?> map) throws Exception {
            UnlockDocRequestParam self = new UnlockDocRequestParam();
            return TeaModel.build(map, self);
        }

        public UnlockDocRequestParam setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public UnlockDocRequestParam setOperatorUid(String operatorUid) {
            this.operatorUid = operatorUid;
            return this;
        }
        public String getOperatorUid() {
            return this.operatorUid;
        }

    }

}
