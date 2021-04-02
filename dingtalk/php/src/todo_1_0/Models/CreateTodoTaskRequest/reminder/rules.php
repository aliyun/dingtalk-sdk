<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\reminder;

use AlibabaCloud\Tea\Model;

class rules extends Model
{
    /**
     * @description startTime:相对开始时间  											//  					dueTime:相对截止时间 											//						customTime: 绝对时间
     *
     * @var string
     */
    public $baseTime;

    /**
     * @description 必须，baseTime 为 startTime 或者 dueTime 时表分钟；比如截止前15分钟为 -15，截止前3小时为 -180;basetime 为 customTime 时为时间戳
     *
     * @var int
     */
    public $offset;
    protected $_name = [
        'baseTime' => 'baseTime',
        'offset'   => 'offset',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->baseTime) {
            $res['baseTime'] = $this->baseTime;
        }
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['baseTime'])) {
            $model->baseTime = $map['baseTime'];
        }
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }

        return $model;
    }
}
