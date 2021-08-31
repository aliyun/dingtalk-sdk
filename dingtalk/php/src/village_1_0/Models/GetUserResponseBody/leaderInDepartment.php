<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody;

use AlibabaCloud\Tea\Model;

class leaderInDepartment extends Model
{
    /**
     * @description 下属组织的部门ID
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description 员工在对应的部门中是否领导
     *
     * @var bool
     */
    public $leader;
    protected $_name = [
        'departmentId' => 'departmentId',
        'leader'       => 'leader',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->leader) {
            $res['leader'] = $this->leader;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return leaderInDepartment
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['leader'])) {
            $model->leader = $map['leader'];
        }

        return $model;
    }
}
