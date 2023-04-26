<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example AUTO_RENAME
     *
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
