<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessRequest;

use AlibabaCloud\Tea\Model;

class copyOptions extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $copyType;
    protected $_name = [
        'copyType' => 'copyType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->copyType) {
            $res['copyType'] = $this->copyType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return copyOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['copyType'])) {
            $model->copyType = $map['copyType'];
        }

        return $model;
    }
}
