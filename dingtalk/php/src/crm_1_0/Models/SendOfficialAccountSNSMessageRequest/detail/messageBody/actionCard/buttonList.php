<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest\detail\messageBody\actionCard;

use AlibabaCloud\Tea\Model;

class buttonList extends Model
{
    /**
     * @description 使用独立跳转ActionCard样式时的跳转链接。
     *
     * @var string
     */
    public $actionUrl;

    /**
     * @description 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
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
