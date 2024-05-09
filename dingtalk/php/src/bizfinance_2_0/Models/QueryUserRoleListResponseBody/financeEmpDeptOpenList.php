<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUserRoleListResponseBody;

use AlibabaCloud\Tea\Model;

class financeEmpDeptOpenList extends Model
{
    /**
     * @var string
     */
    public $cascadeDeptId;

    /**
     * @var int
     */
    public $deptId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $superDeptId;
    protected $_name = [
        'cascadeDeptId' => 'cascadeDeptId',
        'deptId'        => 'deptId',
        'name'          => 'name',
        'superDeptId'   => 'superDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cascadeDeptId) {
            $res['cascadeDeptId'] = $this->cascadeDeptId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->superDeptId) {
            $res['superDeptId'] = $this->superDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return financeEmpDeptOpenList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cascadeDeptId'])) {
            $model->cascadeDeptId = $map['cascadeDeptId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['superDeptId'])) {
            $model->superDeptId = $map['superDeptId'];
        }

        return $model;
    }
}
