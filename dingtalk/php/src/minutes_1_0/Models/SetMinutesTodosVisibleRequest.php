<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetMinutesTodosVisibleRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $todosVisible;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'todosVisible' => 'todosVisible',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->todosVisible) {
            $res['todosVisible'] = $this->todosVisible;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetMinutesTodosVisibleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['todosVisible'])) {
            $model->todosVisible = $map['todosVisible'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
