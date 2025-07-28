<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteDeptInfoRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $deptNo;
    protected $_name = [
        'deptNo' => 'deptNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return params
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }

        return $model;
    }
}
