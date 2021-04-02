<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskResponseBody\reminder;

use AlibabaCloud\Tea\Model;

class rules extends Model
{
    /**
     * @description 目前支持三种类型：tartDate: 相对开始时间；dueDate: 相对截止时间；customDate: 绝对时间
     *
     * @var string
     */
    public $baseTime;

    /**
     * @description 偏移值：baseTime 为 startDate 或者 dueDate 时，offset 为相对分钟的偏移值；baseTime 为 customDate 时，offset 为毫秒时间戳
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
