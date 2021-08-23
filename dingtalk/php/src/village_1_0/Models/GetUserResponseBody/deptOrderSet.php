<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody;

use AlibabaCloud\Tea\Model;

class deptOrderSet extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 员工在部门中的排序。
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
     * @return deptOrderSet
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
