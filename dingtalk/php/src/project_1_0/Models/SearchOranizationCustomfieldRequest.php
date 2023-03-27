<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchOranizationCustomfieldRequest extends Model
{
    /**
     * @description 自定义字段ID集合，逗号组合。
     *
     * @var string
     */
    public $customfieldIds;

    /**
     * @description 字段InstanceId集合，用逗号组合。
     *
     * @var string
     */
    public $instanceIds;

    /**
     * @description 每页返回最大数量。默认10，最大300。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 供分页使用，下一页token，从当前页结果中获取。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 过滤出在指定项目中使用的企业字段，当scope=usedInProjectIds有效。多个以逗号隔开。
     *
     * @var string
     */
    public $projectIds;

    /**
     * @description 过滤字段名字。
     *
     * @var string
     */
    public $query;

    /**
     * @description 字段应用场景, 可以是 sfcAdd,usedInProjectIds,all 其中一个。
     *
     * @var string
     */
    public $scope;
    protected $_name = [
        'customfieldIds' => 'customfieldIds',
        'instanceIds'    => 'instanceIds',
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'projectIds'     => 'projectIds',
        'query'          => 'query',
        'scope'          => 'scope',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customfieldIds) {
            $res['customfieldIds'] = $this->customfieldIds;
        }
        if (null !== $this->instanceIds) {
            $res['instanceIds'] = $this->instanceIds;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->projectIds) {
            $res['projectIds'] = $this->projectIds;
        }
        if (null !== $this->query) {
            $res['query'] = $this->query;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchOranizationCustomfieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customfieldIds'])) {
            $model->customfieldIds = $map['customfieldIds'];
        }
        if (isset($map['instanceIds'])) {
            $model->instanceIds = $map['instanceIds'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['projectIds'])) {
            $model->projectIds = $map['projectIds'];
        }
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }

        return $model;
    }
}
