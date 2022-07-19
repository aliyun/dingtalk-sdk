<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteDentryRequest extends Model
{
    /**
     * @description 是否删除到回收站，默认不删除到回收站，直接删除
     * false
     * @var bool
     */
    public $toRecycleBin;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'toRecycleBin' => 'toRecycleBin',
        'unionId'      => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteDentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['toRecycleBin'])) {
            $model->toRecycleBin = $map['toRecycleBin'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
