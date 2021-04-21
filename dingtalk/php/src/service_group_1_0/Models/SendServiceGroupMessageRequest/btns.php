<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageRequest;

use AlibabaCloud\Tea\Model;

class btns extends Model
{
    /**
     * @description 跳转地址
     *
     * @var string
     */
    public $actionURL;

    /**
     * @description 按钮名称
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'actionURL' => 'actionURL',
        'title'     => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionURL) {
            $res['actionURL'] = $this->actionURL;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return btns
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionURL'])) {
            $model->actionURL = $map['actionURL'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
