<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody\actionCard;

use AlibabaCloud\Tea\Model;

class buttonList extends Model
{
    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $actionUrl;
    protected $_name = [
        'title'     => 'title',
        'actionUrl' => 'actionUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->actionUrl) {
            $res['actionUrl'] = $this->actionUrl;
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
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['actionUrl'])) {
            $model->actionUrl = $map['actionUrl'];
        }

        return $model;
    }
}
