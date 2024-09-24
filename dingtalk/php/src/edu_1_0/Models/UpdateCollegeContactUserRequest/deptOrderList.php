<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactUserRequest;

use AlibabaCloud\Tea\Model;

class deptOrderList extends Model
{
    /**
     * @example 123456
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 1
     *
     * @var int
     */
    public $order;
    protected $_name = [
        'deptId' => 'deptId',
        'order'  => 'order',
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
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptOrderList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }

        return $model;
    }
}
