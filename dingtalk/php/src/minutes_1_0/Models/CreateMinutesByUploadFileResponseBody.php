<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateMinutesByUploadFileResponseBody extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @example 7632756964313430aaaaaaaaaaaaaaaaaaaaaaaaaa7363731333633305f35
     *
     * @var string
     */
    public $taskUuid;
    protected $_name = [
        'bizId' => 'bizId',
        'taskUuid' => 'taskUuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMinutesByUploadFileResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }

        return $model;
    }
}
