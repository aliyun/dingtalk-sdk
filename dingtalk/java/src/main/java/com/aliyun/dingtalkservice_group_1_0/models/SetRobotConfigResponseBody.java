// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SetRobotConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public SetRobotConfigResponseBodyResult result;

    public static SetRobotConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetRobotConfigResponseBody self = new SetRobotConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public SetRobotConfigResponseBody setResult(SetRobotConfigResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SetRobotConfigResponseBodyResult getResult() {
        return this.result;
    }

    public static class SetRobotConfigResponseBodyResult extends TeaModel {
        /**
         * <p>业务Key</p>
         */
        @NameInMap("configKey")
        public String configKey;

        /**
         * <p>业务value</p>
         */
        @NameInMap("configValue")
        public String configValue;

        public static SetRobotConfigResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SetRobotConfigResponseBodyResult self = new SetRobotConfigResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SetRobotConfigResponseBodyResult setConfigKey(String configKey) {
            this.configKey = configKey;
            return this;
        }
        public String getConfigKey() {
            return this.configKey;
        }

        public SetRobotConfigResponseBodyResult setConfigValue(String configValue) {
            this.configValue = configValue;
            return this;
        }
        public String getConfigValue() {
            return this.configValue;
        }

    }

}
