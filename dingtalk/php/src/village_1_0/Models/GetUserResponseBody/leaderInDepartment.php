<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody;

use AlibabaCloud\Tea\Model;

class leaderInDepartment extends Model
{
    /**
     * @var int
     */
    public $departmentId;

    /**
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
