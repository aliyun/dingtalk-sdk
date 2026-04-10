<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdatePersonalTodoTaskExecutorStatusRequest extends Model
{
    /**
     * @var bool
     */
    public $done;
    protected $_name = [
        'done' => 'done',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->done) {
            $res['done'] = $this->done;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePersonalTodoTaskExecutorStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['done'])) {
            $model->done = $map['done'];
        }

        return $model;
    }
}
