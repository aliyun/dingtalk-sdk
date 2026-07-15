// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class CheckDeviceUpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<CheckDeviceUpdateRequestBody> body;

    public static CheckDeviceUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckDeviceUpdateRequest self = new CheckDeviceUpdateRequest();
        return TeaModel.build(map, self);
    }

    public CheckDeviceUpdateRequest setBody(java.util.List<CheckDeviceUpdateRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<CheckDeviceUpdateRequestBody> getBody() {
        return this.body;
    }

    public static class CheckDeviceUpdateRequestBody extends TeaModel {
        @NameInMap("currentVersion")
        public String currentVersion;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("moduleName")
        public String moduleName;

        public static CheckDeviceUpdateRequestBody build(java.util.Map<String, ?> map) throws Exception {
            CheckDeviceUpdateRequestBody self = new CheckDeviceUpdateRequestBody();
            return TeaModel.build(map, self);
        }

        public CheckDeviceUpdateRequestBody setCurrentVersion(String currentVersion) {
            this.currentVersion = currentVersion;
            return this;
        }
        public String getCurrentVersion() {
            return this.currentVersion;
        }

        public CheckDeviceUpdateRequestBody setModuleName(String moduleName) {
            this.moduleName = moduleName;
            return this;
        }
        public String getModuleName() {
            return this.moduleName;
        }

    }

}
