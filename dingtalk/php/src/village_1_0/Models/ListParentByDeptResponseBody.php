<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListParentByDeptResponseBody extends Model
{
    /**
     * @description 父部门列表
     *
     * @var int[]
     */
    public $parentIdList;
    protected $_name = [
        'parentIdList' => 'parentIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->parentIdList) {
            $res['parentIdList'] = $this->parentIdList;
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
        if (isset($map['parentIdList'])) {
            if (!empty($map['parentIdList'])) {
                $model->parentIdList = $map['parentIdList'];
            }
        }

        return $model;
    }
}
