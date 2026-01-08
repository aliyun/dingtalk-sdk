<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result\actionCard;

use AlibabaCloud\Tea\Model;

class buttonList extends Model
{
    /**
     * @var string
     */
    public $actionUrl;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'actionUrl' => 'action_url',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionUrl) {
            $res['action_url'] = $this->actionUrl;
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
        if (isset($map['action_url'])) {
            $model->actionUrl = $map['action_url'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
