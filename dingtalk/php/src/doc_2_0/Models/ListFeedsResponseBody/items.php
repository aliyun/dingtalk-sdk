<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @description 动态内容。
     *
     * @var string
     */
    public $content;

    /**
     * @description 动态时间。
     *
     * @var int
     */
    public $time;

    /**
     * @description 动态类型。
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'content' => 'content',
        'time'    => 'time',
        'type'    => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
