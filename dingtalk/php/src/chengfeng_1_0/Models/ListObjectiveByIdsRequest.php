<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListObjectiveByIdsRequest extends Model
{
    /**
     * @description 目标ID列表
     *
     * @var string[]
     */
    public $objectiveIds;
    protected $_name = [
        'objectiveIds' => 'objectiveIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveIds) {
            $res['objectiveIds'] = $this->objectiveIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListObjectiveByIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveIds'])) {
            if (!empty($map['objectiveIds'])) {
                $model->objectiveIds = $map['objectiveIds'];
            }
        }

        return $model;
    }
}
