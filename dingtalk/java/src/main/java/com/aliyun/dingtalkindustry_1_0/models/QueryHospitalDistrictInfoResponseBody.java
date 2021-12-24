// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalDistrictInfoResponseBody extends TeaModel {
    // 院区病区详情
    @NameInMap("content")
    public java.util.List<QueryHospitalDistrictInfoResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Integer totalPages;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Long currentPage;

    public static QueryHospitalDistrictInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalDistrictInfoResponseBody self = new QueryHospitalDistrictInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryHospitalDistrictInfoResponseBody setContent(java.util.List<QueryHospitalDistrictInfoResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryHospitalDistrictInfoResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryHospitalDistrictInfoResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public QueryHospitalDistrictInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryHospitalDistrictInfoResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryHospitalDistrictInfoResponseBodyContent extends TeaModel {
        // 主键
        @NameInMap("id")
        public Long id;

        // 院区或病区名称
        @NameInMap("districtName")
        public String districtName;

        // 类型，1：院区；2：病区
        @NameInMap("districtType")
        public Integer districtType;

        // 院区id
        @NameInMap("parentDistrictId")
        public Long parentDistrictId;

        // 病区对应的物理地址
        @NameInMap("address")
        public String address;

        // 删除，0:正常，其他：已删除
        @NameInMap("deleted")
        public Integer deleted;

        // 创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 修改时间
        @NameInMap("gmtModified")
        public String gmtModified;

        public static QueryHospitalDistrictInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryHospitalDistrictInfoResponseBodyContent self = new QueryHospitalDistrictInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryHospitalDistrictInfoResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setDistrictName(String districtName) {
            this.districtName = districtName;
            return this;
        }
        public String getDistrictName() {
            return this.districtName;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setDistrictType(Integer districtType) {
            this.districtType = districtType;
            return this;
        }
        public Integer getDistrictType() {
            return this.districtType;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setParentDistrictId(Long parentDistrictId) {
            this.parentDistrictId = parentDistrictId;
            return this;
        }
        public Long getParentDistrictId() {
            return this.parentDistrictId;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setDeleted(Integer deleted) {
            this.deleted = deleted;
            return this;
        }
        public Integer getDeleted() {
            return this.deleted;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

    }

}
