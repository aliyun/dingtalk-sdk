<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdResponseBody;

use AlibabaCloud\Tea\Model;

class deptList extends Model
{
    /**
     * @description id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description name
     *
     * @var string
     */
    public $name;

    /**
     * @description parentId
     *
     * @var int
     */
    public $parentId;
    protected $_name = [
        'deptId'   => 'dept_id',
        'name'     => 'name',
        'parentId' => 'parent_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['dept_id'] = $this->deptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parent_id'] = $this->parentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dept_id'])) {
            $model->deptId = $map['dept_id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parent_id'])) {
            $model->parentId = $map['parent_id'];
        }

        return $model;
    }
}
