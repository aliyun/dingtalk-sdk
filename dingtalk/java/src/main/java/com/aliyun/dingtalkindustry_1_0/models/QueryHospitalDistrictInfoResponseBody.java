// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalDistrictInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryHospitalDistrictInfoResponseBodyContent> content;

    @NameInMap("currentPage")
    public Long currentPage;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("totalPages")
    public Integer totalPages;

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

    public QueryHospitalDistrictInfoResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public QueryHospitalDistrictInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryHospitalDistrictInfoResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public static class QueryHospitalDistrictInfoResponseBodyContent extends TeaModel {
        @NameInMap("address")
        public String address;

        @NameInMap("deleted")
        public Integer deleted;

        @NameInMap("districtName")
        public String districtName;

        @NameInMap("districtType")
        public Integer districtType;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("id")
        public Long id;

        @NameInMap("parentDistrictId")
        public Long parentDistrictId;

        public static QueryHospitalDistrictInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryHospitalDistrictInfoResponseBodyContent self = new QueryHospitalDistrictInfoResponseBodyContent();
            return TeaModel.build(map, self);
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

        public QueryHospitalDistrictInfoResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryHospitalDistrictInfoResponseBodyContent setParentDistrictId(Long parentDistrictId) {
            this.parentDistrictId = parentDistrictId;
            return this;
        }
        public Long getParentDistrictId() {
            return this.parentDistrictId;
        }

    }

}
