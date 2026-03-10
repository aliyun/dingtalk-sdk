<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetMinutesTodosVisibleResponseBody extends Model
{
    /**
     * @var string
     */
    public $taskUuid;

    /**
     * @var bool
     */
    public $todosVisible;
    protected $_name = [
        'taskUuid' => 'taskUuid',
        'todosVisible' => 'todosVisible',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }
        if (null !== $this->todosVisible) {
            $res['todosVisible'] = $this->todosVisible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetMinutesTodosVisibleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }
        if (isset($map['todosVisible'])) {
            $model->todosVisible = $map['todosVisible'];
        }

        return $model;
    }
}
