<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckWritePermissionResponseBody extends Model
{
    /**
     * @description entityPermissionMap
     *
     * @var bool[]
     */
    public $entityPermissionMap;
    protected $_name = [
        'entityPermissionMap' => 'entityPermissionMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->entityPermissionMap) {
            $res['entityPermissionMap'] = $this->entityPermissionMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckWritePermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['entityPermissionMap'])) {
            $model->entityPermissionMap = $map['entityPermissionMap'];
        }

        return $model;
    }
}
