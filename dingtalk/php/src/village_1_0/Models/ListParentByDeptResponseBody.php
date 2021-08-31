<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListParentByDeptResponseBody extends Model
{
    /**
     * @description 父部门ID列表
     *
     * @var int[]
     */
    public $departmentIdList;
    protected $_name = [
        'departmentIdList' => 'departmentIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentIdList) {
            $res['departmentIdList'] = $this->departmentIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListParentByDeptResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentIdList'])) {
            if (!empty($map['departmentIdList'])) {
                $model->departmentIdList = $map['departmentIdList'];
            }
        }

        return $model;
    }
}
