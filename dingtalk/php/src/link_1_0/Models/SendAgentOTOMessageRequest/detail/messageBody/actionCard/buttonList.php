<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody\actionCard;

use AlibabaCloud\Tea\Model;

class buttonList extends Model
{
    /**
     * @example https://www.dingtalk.com/
     *
     * @var string
     */
    public $actionUrl;

    /**
     * @example 查看详情
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'actionUrl' => 'actionUrl',
        'title'     => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionUrl) {
            $res['actionUrl'] = $this->actionUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return buttonList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionUrl'])) {
            $model->actionUrl = $map['actionUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
