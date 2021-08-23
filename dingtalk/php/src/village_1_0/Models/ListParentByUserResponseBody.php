<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListParentByUserResponseBody extends Model
{
    /**
     * @description 上级部门id链
     *
     * @var int[]
     */
    public $parentDeptIdList;
    protected $_name = [
        'parentDeptIdList' => 'parentDeptIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->parentDeptIdList) {
            $res['parentDeptIdList'] = $this->parentDeptIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListParentByUserResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['parentDeptIdList'])) {
            if (!empty($map['parentDeptIdList'])) {
                $model->parentDeptIdList = $map['parentDeptIdList'];
            }
        }

        return $model;
    }
}
