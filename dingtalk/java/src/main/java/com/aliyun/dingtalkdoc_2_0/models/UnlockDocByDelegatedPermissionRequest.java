// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnlockDocByDelegatedPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public UnlockDocByDelegatedPermissionRequestParam param;

    public static UnlockDocByDelegatedPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        UnlockDocByDelegatedPermissionRequest self = new UnlockDocByDelegatedPermissionRequest();
        return TeaModel.build(map, self);
    }

    public UnlockDocByDelegatedPermissionRequest setParam(UnlockDocByDelegatedPermissionRequestParam param) {
        this.param = param;
        return this;
    }
    public UnlockDocByDelegatedPermissionRequestParam getParam() {
        return this.param;
    }

    public static class UnlockDocByDelegatedPermissionRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("dentryUuid")
        public String dentryUuid;

        public static UnlockDocByDelegatedPermissionRequestParam build(java.util.Map<String, ?> map) throws Exception {
            UnlockDocByDelegatedPermissionRequestParam self = new UnlockDocByDelegatedPermissionRequestParam();
            return TeaModel.build(map, self);
        }

        public UnlockDocByDelegatedPermissionRequestParam setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

    }

}
