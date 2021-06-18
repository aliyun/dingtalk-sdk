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
     * @description parentId
     *
     * @var int
     */
    public $parentId;

    /**
     * @description name
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'deptId'   => 'dept_id',
        'parentId' => 'parent_id',
        'name'     => 'name',
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
        if (null !== $this->parentId) {
            $res['parent_id'] = $this->parentId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (isset($map['parent_id'])) {
            $model->parentId = $map['parent_id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
