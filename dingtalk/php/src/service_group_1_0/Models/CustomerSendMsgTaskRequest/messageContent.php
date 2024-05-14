<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest\messageContent\btns;
use AlibabaCloud\Tea\Model;

class messageContent extends Model
{
    /**
     * @var btns[]
     */
    public $btns;

    /**
     * @description This parameter is required.
     *
     * @example 内容
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example ACTIONCAR：卡片消息
     *
     * @var string
     */
    public $messageType;

    /**
     * @description This parameter is required.
     *
     * @example 标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'btns'        => 'btns',
        'content'     => 'content',
        'messageType' => 'messageType',
        'title'       => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->btns) {
            $res['btns'] = [];
            if (null !== $this->btns && \is_array($this->btns)) {
                $n = 0;
                foreach ($this->btns as $item) {
                    $res['btns'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return messageContent
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['btns'])) {
            if (!empty($map['btns'])) {
                $model->btns = [];
                $n           = 0;
                foreach ($map['btns'] as $item) {
                    $model->btns[$n++] = null !== $item ? btns::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
