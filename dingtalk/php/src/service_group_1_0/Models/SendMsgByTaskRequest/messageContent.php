<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest\messageContent\btns;
use AlibabaCloud\Tea\Model;

class messageContent extends Model
{
    /**
     * @description 是否At全部人员
     *
     * @var bool
     */
    public $atAll;

    /**
     * @description 是否At活跃成员
     *
     * @var bool
     */
    public $atActiveUser;

    /**
     * @description 消息类型
     *
     * @var string
     */
    public $messageType;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 图片列表
     *
     * @var string[]
     */
    public $images;

    /**
     * @var btns[]
     */
    public $btns;

    /**
     * @description at活跃成员数量
     *
     * @var int
     */
    public $atActiveMemberNum;
    protected $_name = [
        'atAll'             => 'atAll',
        'atActiveUser'      => 'atActiveUser',
        'messageType'       => 'messageType',
        'title'             => 'title',
        'content'           => 'content',
        'images'            => 'images',
        'btns'              => 'btns',
        'atActiveMemberNum' => 'atActiveMemberNum',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->atActiveUser) {
            $res['atActiveUser'] = $this->atActiveUser;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->images) {
            $res['images'] = $this->images;
        }
        if (null !== $this->btns) {
            $res['btns'] = [];
            if (null !== $this->btns && \is_array($this->btns)) {
                $n = 0;
                foreach ($this->btns as $item) {
                    $res['btns'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->atActiveMemberNum) {
            $res['atActiveMemberNum'] = $this->atActiveMemberNum;
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
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['atActiveUser'])) {
            $model->atActiveUser = $map['atActiveUser'];
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['images'])) {
            if (!empty($map['images'])) {
                $model->images = $map['images'];
            }
        }
        if (isset($map['btns'])) {
            if (!empty($map['btns'])) {
                $model->btns = [];
                $n           = 0;
                foreach ($map['btns'] as $item) {
                    $model->btns[$n++] = null !== $item ? btns::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['atActiveMemberNum'])) {
            $model->atActiveMemberNum = $map['atActiveMemberNum'];
        }

        return $model;
    }
}
