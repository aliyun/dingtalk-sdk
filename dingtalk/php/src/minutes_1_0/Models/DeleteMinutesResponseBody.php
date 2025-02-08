<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteMinutesResponseBody extends Model
{
    /**
     * @var string
     */
    public $taskUuid;
    protected $_name = [
        'taskUuid' => 'taskUuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteMinutesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }

        return $model;
    }
}
