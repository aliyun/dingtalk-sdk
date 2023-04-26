<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example "{}"
     *
     * @var string
     */
    public $content;

    /**
     * @example 12340000
     *
     * @var int
     */
    public $time;

    /**
     * @example 1
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
