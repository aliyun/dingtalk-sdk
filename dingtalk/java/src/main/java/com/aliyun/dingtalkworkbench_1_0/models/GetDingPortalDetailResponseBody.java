// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetDingPortalDetailResponseBody extends TeaModel {
    // 工作台ID
    @NameInMap("appUuid")
    public String appUuid;

    // 工作台名称
    @NameInMap("dingPortalName")
    public String dingPortalName;

    // 工作台页面信息
    @NameInMap("pages")
    public java.util.List<GetDingPortalDetailResponseBodyPages> pages;

    public static GetDingPortalDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDingPortalDetailResponseBody self = new GetDingPortalDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDingPortalDetailResponseBody setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public GetDingPortalDetailResponseBody setDingPortalName(String dingPortalName) {
        this.dingPortalName = dingPortalName;
        return this;
    }
    public String getDingPortalName() {
        return this.dingPortalName;
    }

    public GetDingPortalDetailResponseBody setPages(java.util.List<GetDingPortalDetailResponseBodyPages> pages) {
        this.pages = pages;
        return this;
    }
    public java.util.List<GetDingPortalDetailResponseBodyPages> getPages() {
        return this.pages;
    }

    public static class GetDingPortalDetailResponseBodyPages extends TeaModel {
        // 是否全公司可见
        @NameInMap("allVisible")
        public Boolean allVisible;

        // 可见部门 ID 铺
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        // 页面名称
        @NameInMap("pageName")
        public String pageName;

        // 页面ID
        @NameInMap("pageUuid")
        public String pageUuid;

        // 可见角色列表
        @NameInMap("roleIds")
        public java.util.List<Long> roleIds;

        // 可见员工 ID 列表
        @NameInMap("userids")
        public java.util.List<String> userids;

        public static GetDingPortalDetailResponseBodyPages build(java.util.Map<String, ?> map) throws Exception {
            GetDingPortalDetailResponseBodyPages self = new GetDingPortalDetailResponseBodyPages();
            return TeaModel.build(map, self);
        }

        public GetDingPortalDetailResponseBodyPages setAllVisible(Boolean allVisible) {
            this.allVisible = allVisible;
            return this;
        }
        public Boolean getAllVisible() {
            return this.allVisible;
        }

        public GetDingPortalDetailResponseBodyPages setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public GetDingPortalDetailResponseBodyPages setPageName(String pageName) {
            this.pageName = pageName;
            return this;
        }
        public String getPageName() {
            return this.pageName;
        }

        public GetDingPortalDetailResponseBodyPages setPageUuid(String pageUuid) {
            this.pageUuid = pageUuid;
            return this;
        }
        public String getPageUuid() {
            return this.pageUuid;
        }

        public GetDingPortalDetailResponseBodyPages setRoleIds(java.util.List<Long> roleIds) {
            this.roleIds = roleIds;
            return this;
        }
        public java.util.List<Long> getRoleIds() {
            return this.roleIds;
        }

        public GetDingPortalDetailResponseBodyPages setUserids(java.util.List<String> userids) {
            this.userids = userids;
            return this;
        }
        public java.util.List<String> getUserids() {
            return this.userids;
        }

    }

}
