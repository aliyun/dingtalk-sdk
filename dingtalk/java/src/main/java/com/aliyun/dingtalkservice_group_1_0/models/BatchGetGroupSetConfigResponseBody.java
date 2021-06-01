// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchGetGroupSetConfigResponseBody extends TeaModel {
    // 群粗配置列表
    @NameInMap("groupSetConfigs")
    public java.util.List<BatchGetGroupSetConfigResponseBodyGroupSetConfigs> groupSetConfigs;

    public static BatchGetGroupSetConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetGroupSetConfigResponseBody self = new BatchGetGroupSetConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetGroupSetConfigResponseBody setGroupSetConfigs(java.util.List<BatchGetGroupSetConfigResponseBodyGroupSetConfigs> groupSetConfigs) {
        this.groupSetConfigs = groupSetConfigs;
        return this;
    }
    public java.util.List<BatchGetGroupSetConfigResponseBodyGroupSetConfigs> getGroupSetConfigs() {
        return this.groupSetConfigs;
    }

    public static class BatchGetGroupSetConfigResponseBodyGroupSetConfigs extends TeaModel {
        // 配置项key
        @NameInMap("configKey")
        public String configKey;

        // 配置项值
        @NameInMap("configValue")
        public String configValue;

        public static BatchGetGroupSetConfigResponseBodyGroupSetConfigs build(java.util.Map<String, ?> map) throws Exception {
            BatchGetGroupSetConfigResponseBodyGroupSetConfigs self = new BatchGetGroupSetConfigResponseBodyGroupSetConfigs();
            return TeaModel.build(map, self);
        }

        public BatchGetGroupSetConfigResponseBodyGroupSetConfigs setConfigKey(String configKey) {
            this.configKey = configKey;
            return this;
        }
        public String getConfigKey() {
            return this.configKey;
        }

        public BatchGetGroupSetConfigResponseBodyGroupSetConfigs setConfigValue(String configValue) {
            this.configValue = configValue;
            return this;
        }
        public String getConfigValue() {
            return this.configValue;
        }

    }

}
