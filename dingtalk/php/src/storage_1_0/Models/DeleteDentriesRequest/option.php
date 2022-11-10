<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 是否删除到回收站，默认不删除到回收站，直接删除
     * false
     * @var bool
     */
    public $toRecycleBin;
    protected $_name = [
        'toRecycleBin' => 'toRecycleBin',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->toRecycleBin) {
            $res['toRecycleBin'] = $this->toRecycleBin;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['toRecycleBin'])) {
            $model->toRecycleBin = $map['toRecycleBin'];
        }

        return $model;
    }
}
