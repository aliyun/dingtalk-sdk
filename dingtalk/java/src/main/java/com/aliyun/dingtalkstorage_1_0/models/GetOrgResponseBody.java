// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetOrgResponseBody extends TeaModel {
    @NameInMap("org")
    public GetOrgResponseBodyOrg org;

    public static GetOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrgResponseBody self = new GetOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrgResponseBody setOrg(GetOrgResponseBodyOrg org) {
        this.org = org;
        return this;
    }
    public GetOrgResponseBodyOrg getOrg() {
        return this.org;
    }

    public static class GetOrgResponseBodyOrgPartitionsQuota extends TeaModel {
        @NameInMap("max")
        public Long max;

        @NameInMap("reserved")
        public Long reserved;

        @NameInMap("type")
        public String type;

        @NameInMap("used")
        public Long used;

        public static GetOrgResponseBodyOrgPartitionsQuota build(java.util.Map<String, ?> map) throws Exception {
            GetOrgResponseBodyOrgPartitionsQuota self = new GetOrgResponseBodyOrgPartitionsQuota();
            return TeaModel.build(map, self);
        }

        public GetOrgResponseBodyOrgPartitionsQuota setMax(Long max) {
            this.max = max;
            return this;
        }
        public Long getMax() {
            return this.max;
        }

        public GetOrgResponseBodyOrgPartitionsQuota setReserved(Long reserved) {
            this.reserved = reserved;
            return this;
        }
        public Long getReserved() {
            return this.reserved;
        }

        public GetOrgResponseBodyOrgPartitionsQuota setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetOrgResponseBodyOrgPartitionsQuota setUsed(Long used) {
            this.used = used;
            return this;
        }
        public Long getUsed() {
            return this.used;
        }

    }

    public static class GetOrgResponseBodyOrgPartitions extends TeaModel {
        @NameInMap("partitionType")
        public String partitionType;

        @NameInMap("quota")
        public GetOrgResponseBodyOrgPartitionsQuota quota;

        public static GetOrgResponseBodyOrgPartitions build(java.util.Map<String, ?> map) throws Exception {
            GetOrgResponseBodyOrgPartitions self = new GetOrgResponseBodyOrgPartitions();
            return TeaModel.build(map, self);
        }

        public GetOrgResponseBodyOrgPartitions setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public GetOrgResponseBodyOrgPartitions setQuota(GetOrgResponseBodyOrgPartitionsQuota quota) {
            this.quota = quota;
            return this;
        }
        public GetOrgResponseBodyOrgPartitionsQuota getQuota() {
            return this.quota;
        }

    }

    public static class GetOrgResponseBodyOrg extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("partitions")
        public java.util.List<GetOrgResponseBodyOrgPartitions> partitions;

        public static GetOrgResponseBodyOrg build(java.util.Map<String, ?> map) throws Exception {
            GetOrgResponseBodyOrg self = new GetOrgResponseBodyOrg();
            return TeaModel.build(map, self);
        }

        public GetOrgResponseBodyOrg setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetOrgResponseBodyOrg setPartitions(java.util.List<GetOrgResponseBodyOrgPartitions> partitions) {
            this.partitions = partitions;
            return this;
        }
        public java.util.List<GetOrgResponseBodyOrgPartitions> getPartitions() {
            return this.partitions;
        }

    }

}
