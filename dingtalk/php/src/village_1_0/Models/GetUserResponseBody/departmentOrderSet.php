<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody;

use AlibabaCloud\Tea\Model;

class departmentOrderSet extends Model
{
    /**
     * @description 下属组织的部门ID
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description 员工在部门中的排序。
     *
     * @var int
     */
    public $order;
    protected $_name = [
        'departmentId' => 'departmentId',
        'order'        => 'order',
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
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return departmentOrderSet
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }

        return $model;
    }
}
