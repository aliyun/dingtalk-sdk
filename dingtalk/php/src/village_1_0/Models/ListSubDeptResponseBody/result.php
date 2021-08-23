<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 部门ID
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'deptId' => 'deptId',
        'name'   => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
