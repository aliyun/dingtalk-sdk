<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class leaderInDept extends Model
{
    /**
     * @example 123456
     *
     * @var int
     */
    public $deptId;

    /**
     * @var bool
     */
    public $leader;
    protected $_name = [
        'deptId' => 'deptId',
        'leader' => 'leader',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->leader) {
            $res['leader'] = $this->leader;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return leaderInDept
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['leader'])) {
            $model->leader = $map['leader'];
        }

        return $model;
    }
}
