<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class MoveOutTempStorageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example a1b2c3d4e5f67890a1b2c3d4e5f67890
     *
     * @var string
     */
    public $taskUuid;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'taskUuid' => 'taskUuid',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MoveOutTempStorageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
