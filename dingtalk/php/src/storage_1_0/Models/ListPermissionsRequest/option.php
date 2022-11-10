<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 角色过滤列表
     * 30
     * @var string[]
     */
    public $filterRoleIds;

    /**
     * @description 分页大小
     * 50
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'filterRoleIds' => 'filterRoleIds',
        'maxResults'    => 'maxResults',
        'nextToken'     => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->filterRoleIds) {
            $res['filterRoleIds'] = $this->filterRoleIds;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['filterRoleIds'])) {
            if (!empty($map['filterRoleIds'])) {
                $model->filterRoleIds = $map['filterRoleIds'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
