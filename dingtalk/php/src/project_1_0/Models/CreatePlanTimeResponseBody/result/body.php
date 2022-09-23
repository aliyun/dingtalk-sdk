<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreatePlanTimeResponseBody\result;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 更新工时所属日期
     *
     * @var string
     */
    public $date;

    /**
     * @description 工时关联的数据id
     *
     * @var string
     */
    public $objectId;

    /**
     * @description 计划工时数
     *
     * @var int
     */
    public $planTime;
    protected $_name = [
        'date'     => 'date',
        'objectId' => 'objectId',
        'planTime' => 'planTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->objectId) {
            $res['objectId'] = $this->objectId;
        }
        if (null !== $this->planTime) {
            $res['planTime'] = $this->planTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['objectId'])) {
            $model->objectId = $map['objectId'];
        }
        if (isset($map['planTime'])) {
            $model->planTime = $map['planTime'];
        }

        return $model;
    }
}
