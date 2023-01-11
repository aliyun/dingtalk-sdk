// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectsResponseBody extends TeaModel {
    /**
     * <p>状态码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("data")
    public LoadBizObjectsResponseBodyData data;

    /**
     * <p>提示信息</p>
     */
    @NameInMap("message")
    public String message;

    public static LoadBizObjectsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LoadBizObjectsResponseBody self = new LoadBizObjectsResponseBody();
        return TeaModel.build(map, self);
    }

    public LoadBizObjectsResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public LoadBizObjectsResponseBody setData(LoadBizObjectsResponseBodyData data) {
        this.data = data;
        return this;
    }
    public LoadBizObjectsResponseBodyData getData() {
        return this.data;
    }

    public LoadBizObjectsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class LoadBizObjectsResponseBodyData extends TeaModel {
        /**
         * <p>业务数据实例数组</p>
         */
        @NameInMap("bizObjects")
        public java.util.List<java.util.Map<String, ?>> bizObjects;

        /**
         * <p>页码</p>
         */
        @NameInMap("pageNumber")
        public Integer pageNumber;

        /**
         * <p>页大小</p>
         */
        @NameInMap("pageSize")
        public Integer pageSize;

        /**
         * <p>匹配条件的结果总数量</p>
         */
        @NameInMap("totalCount")
        public Integer totalCount;

        public static LoadBizObjectsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            LoadBizObjectsResponseBodyData self = new LoadBizObjectsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public LoadBizObjectsResponseBodyData setBizObjects(java.util.List<java.util.Map<String, ?>> bizObjects) {
            this.bizObjects = bizObjects;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getBizObjects() {
            return this.bizObjects;
        }

        public LoadBizObjectsResponseBodyData setPageNumber(Integer pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Integer getPageNumber() {
            return this.pageNumber;
        }

        public LoadBizObjectsResponseBodyData setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

        public LoadBizObjectsResponseBodyData setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
