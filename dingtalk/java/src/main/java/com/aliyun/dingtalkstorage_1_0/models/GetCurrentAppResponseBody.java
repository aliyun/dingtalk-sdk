// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetCurrentAppResponseBody extends TeaModel {
    @NameInMap("app")
    public GetCurrentAppResponseBodyApp app;

    public static GetCurrentAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCurrentAppResponseBody self = new GetCurrentAppResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCurrentAppResponseBody setApp(GetCurrentAppResponseBodyApp app) {
        this.app = app;
        return this;
    }
    public GetCurrentAppResponseBodyApp getApp() {
        return this.app;
    }

    public static class GetCurrentAppResponseBodyAppPartitionsQuota extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>10000</p>
         */
        @NameInMap("max")
        public Long max;

        /**
         * <strong>example:</strong>
         * <p>1000</p>
         */
        @NameInMap("reserved")
        public Long reserved;

        /**
         * <strong>example:</strong>
         * <p>SHARE</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>1024</p>
         */
        @NameInMap("used")
        public Long used;

        public static GetCurrentAppResponseBodyAppPartitionsQuota build(java.util.Map<String, ?> map) throws Exception {
            GetCurrentAppResponseBodyAppPartitionsQuota self = new GetCurrentAppResponseBodyAppPartitionsQuota();
            return TeaModel.build(map, self);
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setMax(Long max) {
            this.max = max;
            return this;
        }
        public Long getMax() {
            return this.max;
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setReserved(Long reserved) {
            this.reserved = reserved;
            return this;
        }
        public Long getReserved() {
            return this.reserved;
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setUsed(Long used) {
            this.used = used;
            return this;
        }
        public Long getUsed() {
            return this.used;
        }

    }

    public static class GetCurrentAppResponseBodyAppPartitions extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>PUBLIC_OSS_PARTITION</p>
         */
        @NameInMap("partitionType")
        public String partitionType;

        @NameInMap("quota")
        public GetCurrentAppResponseBodyAppPartitionsQuota quota;

        public static GetCurrentAppResponseBodyAppPartitions build(java.util.Map<String, ?> map) throws Exception {
            GetCurrentAppResponseBodyAppPartitions self = new GetCurrentAppResponseBodyAppPartitions();
            return TeaModel.build(map, self);
        }

        public GetCurrentAppResponseBodyAppPartitions setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public GetCurrentAppResponseBodyAppPartitions setQuota(GetCurrentAppResponseBodyAppPartitionsQuota quota) {
            this.quota = quota;
            return this;
        }
        public GetCurrentAppResponseBodyAppPartitionsQuota getQuota() {
            return this.quota;
        }

    }

    public static class GetCurrentAppResponseBodyApp extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>app_id</p>
         */
        @NameInMap("appId")
        public String appId;

        /**
         * <strong>example:</strong>
         * <p>corp_id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>2022-01-01T10:00:00Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>2022-01-01T10:00:00Z</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <strong>example:</strong>
         * <p>app_name</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("partitions")
        public java.util.List<GetCurrentAppResponseBodyAppPartitions> partitions;

        public static GetCurrentAppResponseBodyApp build(java.util.Map<String, ?> map) throws Exception {
            GetCurrentAppResponseBodyApp self = new GetCurrentAppResponseBodyApp();
            return TeaModel.build(map, self);
        }

        public GetCurrentAppResponseBodyApp setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public GetCurrentAppResponseBodyApp setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCurrentAppResponseBodyApp setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetCurrentAppResponseBodyApp setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetCurrentAppResponseBodyApp setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCurrentAppResponseBodyApp setPartitions(java.util.List<GetCurrentAppResponseBodyAppPartitions> partitions) {
            this.partitions = partitions;
            return this;
        }
        public java.util.List<GetCurrentAppResponseBodyAppPartitions> getPartitions() {
            return this.partitions;
        }

    }

}
