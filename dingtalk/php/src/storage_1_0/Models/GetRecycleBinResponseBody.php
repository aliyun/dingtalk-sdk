<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleBinResponseBody\recycleBin;
use AlibabaCloud\Tea\Model;

class GetRecycleBinResponseBody extends Model
{
    /**
     * @description 回收站信息
     *
     * @var recycleBin
     */
    public $recycleBin;
    protected $_name = [
        'recycleBin' => 'recycleBin',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recycleBin) {
            $res['recycleBin'] = null !== $this->recycleBin ? $this->recycleBin->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRecycleBinResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recycleBin'])) {
            $model->recycleBin = recycleBin::fromMap($map['recycleBin']);
        }

        return $model;
    }
}
