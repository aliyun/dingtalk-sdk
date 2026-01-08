<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddRecordPermissionResponseBody extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @example 76327xxxxxxx353936325f35
     *
     * @var string
     */
    public $taskUuid;
    protected $_name = [
        'code' => 'code',
        'taskUuid' => 'taskUuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRecordPermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }

        return $model;
    }
}
