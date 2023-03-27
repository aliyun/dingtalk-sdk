// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectStatusListResponseBody extends TeaModel {
    /**
     * <p>项目状态历史列表。</p>
     */
    @NameInMap("result")
    public java.util.List<GetProjectStatusListResponseBodyResult> result;

    public static GetProjectStatusListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProjectStatusListResponseBody self = new GetProjectStatusListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProjectStatusListResponseBody setResult(java.util.List<GetProjectStatusListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetProjectStatusListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetProjectStatusListResponseBodyResult extends TeaModel {
        /**
         * <p>项目状态内容。</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>创建时间。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>项目状态创建人ID。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>项目状态指标：'normal','risky','urgent'。</p>
         */
        @NameInMap("degree")
        public String degree;

        /**
         * <p>项目状态名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>项目ID。</p>
         */
        @NameInMap("projectId")
        public String projectId;

        public static GetProjectStatusListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProjectStatusListResponseBodyResult self = new GetProjectStatusListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProjectStatusListResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetProjectStatusListResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetProjectStatusListResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetProjectStatusListResponseBodyResult setDegree(String degree) {
            this.degree = degree;
            return this;
        }
        public String getDegree() {
            return this.degree;
        }

        public GetProjectStatusListResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProjectStatusListResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

    }

}
