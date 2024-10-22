// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetCategorySourceConfigListResponseBody extends TeaModel {
    @NameInMap("configs")
    public java.util.List<GetCategorySourceConfigListResponseBodyConfigs> configs;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static GetCategorySourceConfigListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCategorySourceConfigListResponseBody self = new GetCategorySourceConfigListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCategorySourceConfigListResponseBody setConfigs(java.util.List<GetCategorySourceConfigListResponseBodyConfigs> configs) {
        this.configs = configs;
        return this;
    }
    public java.util.List<GetCategorySourceConfigListResponseBodyConfigs> getConfigs() {
        return this.configs;
    }

    public GetCategorySourceConfigListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetCategorySourceConfigListResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class GetCategorySourceConfigListResponseBodyConfigs extends TeaModel {
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        @NameInMap("bizCategoryName")
        public String bizCategoryName;

        @NameInMap("configId")
        public String configId;

        public static GetCategorySourceConfigListResponseBodyConfigs build(java.util.Map<String, ?> map) throws Exception {
            GetCategorySourceConfigListResponseBodyConfigs self = new GetCategorySourceConfigListResponseBodyConfigs();
            return TeaModel.build(map, self);
        }

        public GetCategorySourceConfigListResponseBodyConfigs setBizCategoryId(String bizCategoryId) {
            this.bizCategoryId = bizCategoryId;
            return this;
        }
        public String getBizCategoryId() {
            return this.bizCategoryId;
        }

        public GetCategorySourceConfigListResponseBodyConfigs setBizCategoryName(String bizCategoryName) {
            this.bizCategoryName = bizCategoryName;
            return this;
        }
        public String getBizCategoryName() {
            return this.bizCategoryName;
        }

        public GetCategorySourceConfigListResponseBodyConfigs setConfigId(String configId) {
            this.configId = configId;
            return this;
        }
        public String getConfigId() {
            return this.configId;
        }

    }

}
