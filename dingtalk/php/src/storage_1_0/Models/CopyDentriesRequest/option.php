<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 文件(夹)名称冲突策略
     * AUTO_RENAME
     * @var string
     */
    public $conflictStrategy;
    protected $_name = [
        'conflictStrategy' => 'conflictStrategy',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conflictStrategy) {
            $res['conflictStrategy'] = $this->conflictStrategy;
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
        if (isset($map['conflictStrategy'])) {
            $model->conflictStrategy = $map['conflictStrategy'];
        }

        return $model;
    }
}
