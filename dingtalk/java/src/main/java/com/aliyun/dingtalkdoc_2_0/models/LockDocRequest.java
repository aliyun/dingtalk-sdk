// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class LockDocRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public LockDocRequestParam param;

    public static LockDocRequest build(java.util.Map<String, ?> map) throws Exception {
        LockDocRequest self = new LockDocRequest();
        return TeaModel.build(map, self);
    }

    public LockDocRequest setParam(LockDocRequestParam param) {
        this.param = param;
        return this;
    }
    public LockDocRequestParam getParam() {
        return this.param;
    }

    public static class LockDocRequestParam extends TeaModel {
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
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>operatorUid</p>
         */
        @NameInMap("operatorUid")
        public String operatorUid;

        public static LockDocRequestParam build(java.util.Map<String, ?> map) throws Exception {
            LockDocRequestParam self = new LockDocRequestParam();
            return TeaModel.build(map, self);
        }

        public LockDocRequestParam setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public LockDocRequestParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public LockDocRequestParam setOperatorUid(String operatorUid) {
            this.operatorUid = operatorUid;
            return this;
        }
        public String getOperatorUid() {
            return this.operatorUid;
        }

    }

}
