// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class LockDocByDelegatedPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public LockDocByDelegatedPermissionRequestParam param;

    public static LockDocByDelegatedPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        LockDocByDelegatedPermissionRequest self = new LockDocByDelegatedPermissionRequest();
        return TeaModel.build(map, self);
    }

    public LockDocByDelegatedPermissionRequest setParam(LockDocByDelegatedPermissionRequestParam param) {
        this.param = param;
        return this;
    }
    public LockDocByDelegatedPermissionRequestParam getParam() {
        return this.param;
    }

    public static class LockDocByDelegatedPermissionRequestParam extends TeaModel {
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

        public static LockDocByDelegatedPermissionRequestParam build(java.util.Map<String, ?> map) throws Exception {
            LockDocByDelegatedPermissionRequestParam self = new LockDocByDelegatedPermissionRequestParam();
            return TeaModel.build(map, self);
        }

        public LockDocByDelegatedPermissionRequestParam setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public LockDocByDelegatedPermissionRequestParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
