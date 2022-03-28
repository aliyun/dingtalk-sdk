<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoResponseBody\result;

use AlibabaCloud\Tea\Model;

class deptList extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 部门路径
     *
     * @var string
     */
    public $deptPath;
    protected $_name = [
        'deptId'   => 'dept_id',
        'deptPath' => 'dept_path',
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
        if (null !== $this->deptPath) {
            $res['dept_path'] = $this->deptPath;
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
        if (isset($map['dept_path'])) {
            $model->deptPath = $map['dept_path'];
        }

        return $model;
    }
}
