// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageGetQuotaDataResponseBody extends TeaModel {
    /**
     * <p>文件存储使用容量列表</p>
     */
    @NameInMap("quotaModelList")
    public java.util.List<FileStorageGetQuotaDataResponseBodyQuotaModelList> quotaModelList;

    public static FileStorageGetQuotaDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FileStorageGetQuotaDataResponseBody self = new FileStorageGetQuotaDataResponseBody();
        return TeaModel.build(map, self);
    }

    public FileStorageGetQuotaDataResponseBody setQuotaModelList(java.util.List<FileStorageGetQuotaDataResponseBodyQuotaModelList> quotaModelList) {
        this.quotaModelList = quotaModelList;
        return this;
    }
    public java.util.List<FileStorageGetQuotaDataResponseBodyQuotaModelList> getQuotaModelList() {
        return this.quotaModelList;
    }

    public static class FileStorageGetQuotaDataResponseBodyQuotaModelList extends TeaModel {
        /**
         * <p>统计时间点</p>
         */
        @NameInMap("statisticTime")
        public String statisticTime;

        /**
         * <p>使用的容量（byte）</p>
         */
        @NameInMap("usedStorage")
        public Long usedStorage;

        public static FileStorageGetQuotaDataResponseBodyQuotaModelList build(java.util.Map<String, ?> map) throws Exception {
            FileStorageGetQuotaDataResponseBodyQuotaModelList self = new FileStorageGetQuotaDataResponseBodyQuotaModelList();
            return TeaModel.build(map, self);
        }

        public FileStorageGetQuotaDataResponseBodyQuotaModelList setStatisticTime(String statisticTime) {
            this.statisticTime = statisticTime;
            return this;
        }
        public String getStatisticTime() {
            return this.statisticTime;
        }

        public FileStorageGetQuotaDataResponseBodyQuotaModelList setUsedStorage(Long usedStorage) {
            this.usedStorage = usedStorage;
            return this;
        }
        public Long getUsedStorage() {
            return this.usedStorage;
        }

    }

}
