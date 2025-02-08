<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetMinutesDetailsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $taskUuids;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'taskUuids' => 'taskUuids',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskUuids) {
            $res['taskUuids'] = $this->taskUuids;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetMinutesDetailsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskUuids'])) {
            if (!empty($map['taskUuids'])) {
                $model->taskUuids = $map['taskUuids'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
