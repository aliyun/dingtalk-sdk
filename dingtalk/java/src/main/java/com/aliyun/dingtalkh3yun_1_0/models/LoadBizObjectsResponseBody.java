// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectsResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 返回结果
    @NameInMap("data")
    public LoadBizObjectsResponseBodyData data;

    // 提示信息
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
        // 业务数据实例数组
        @NameInMap("bizObjects")
        public java.util.List<java.util.Map<String, ?>> bizObjects;

        // 页码
        @NameInMap("pageNumber")
        public Integer pageNumber;

        // 页大小
        @NameInMap("pageSize")
        public Integer pageSize;

        // 匹配条件的结果总数量
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
