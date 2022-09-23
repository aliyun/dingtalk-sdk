<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeResponseBody\result;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 工时所属日期
     *
     * @var string
     */
    public $date;

    /**
     * @description 工时关联的数据 ID
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 实际工时
     *
     * @var int
     */
    public $workTime;
    protected $_name = [
        'date'     => 'date',
        'taskId'   => 'taskId',
        'workTime' => 'workTime',
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
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->workTime) {
            $res['workTime'] = $this->workTime;
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
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['workTime'])) {
            $model->workTime = $map['workTime'];
        }

        return $model;
    }
}
