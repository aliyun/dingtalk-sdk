<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteSpaceRequest extends Model
{
    /**
     * @description 部门id
     *
     * @var int[]
     */
    public $deptIds;
    protected $_name = [
        'deptIds' => 'deptIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }

        return $model;
    }
}
