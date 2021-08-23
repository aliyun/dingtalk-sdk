<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSubDeptIdsResponseBody extends Model
{
    /**
     * @description 部门ID列表
     *
     * @var int[]
     */
    public $deptIdList;
    protected $_name = [
        'deptIdList' => 'deptIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSubDeptIdsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }

        return $model;
    }
}
