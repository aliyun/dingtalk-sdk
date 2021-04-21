<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ClearRecycleFilesRequest extends Model
{
    /**
     * @description 回收站类型
     *
     * @var string
     */
    public $recycleType;
    protected $_name = [
        'recycleType' => 'recycleType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recycleType) {
            $res['recycleType'] = $this->recycleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ClearRecycleFilesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recycleType'])) {
            $model->recycleType = $map['recycleType'];
        }

        return $model;
    }
}
