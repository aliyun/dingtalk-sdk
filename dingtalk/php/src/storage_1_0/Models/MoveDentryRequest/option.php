<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentryRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example AUTO_RENAME
     *
     * @var string
     */
    public $conflictStrategy;

    /**
     * @example true
     *
     * @var bool
     */
    public $presevePermissions;
    protected $_name = [
        'conflictStrategy'   => 'conflictStrategy',
        'presevePermissions' => 'presevePermissions',
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
        if (null !== $this->presevePermissions) {
            $res['presevePermissions'] = $this->presevePermissions;
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
        if (isset($map['presevePermissions'])) {
            $model->presevePermissions = $map['presevePermissions'];
        }

        return $model;
    }
}
