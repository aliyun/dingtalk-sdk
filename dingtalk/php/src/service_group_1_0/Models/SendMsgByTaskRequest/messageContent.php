<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest\messageContent\btns;
use AlibabaCloud\Tea\Model;

class messageContent extends Model
{
    /**
     * @description at活跃成员数量
     *
     * @var int
     */
    public $atActiveMemberNum;

    /**
     * @description 是否At活跃成员
     *
     * @var bool
     */
    public $atActiveUser;

    /**
     * @description 是否At全部人员
     *
     * @var bool
     */
    public $atAll;

    /**
     * @var btns[]
     */
    public $btns;

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
     * @description 消息类型
     *
     * @var string
     */
    public $messageType;

    /**
     * @description 是否提醒群成员
     *
     * @var bool
     */
    public $remind;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 是否置顶
     *
     * @var bool
     */
    public $top;
    protected $_name = [
        'atActiveMemberNum' => 'atActiveMemberNum',
        'atActiveUser'      => 'atActiveUser',
        'atAll'             => 'atAll',
        'btns'              => 'btns',
        'content'           => 'content',
        'images'            => 'images',
        'messageType'       => 'messageType',
        'remind'            => 'remind',
        'title'             => 'title',
        'top'               => 'top',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atActiveMemberNum) {
            $res['atActiveMemberNum'] = $this->atActiveMemberNum;
        }
        if (null !== $this->atActiveUser) {
            $res['atActiveUser'] = $this->atActiveUser;
        }
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
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
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->images) {
            $res['images'] = $this->images;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
        }
        if (null !== $this->remind) {
            $res['remind'] = $this->remind;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->top) {
            $res['top'] = $this->top;
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
        if (isset($map['atActiveMemberNum'])) {
            $model->atActiveMemberNum = $map['atActiveMemberNum'];
        }
        if (isset($map['atActiveUser'])) {
            $model->atActiveUser = $map['atActiveUser'];
        }
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['images'])) {
            if (!empty($map['images'])) {
                $model->images = $map['images'];
            }
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
        }
        if (isset($map['remind'])) {
            $model->remind = $map['remind'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['top'])) {
            $model->top = $map['top'];
        }

        return $model;
    }
}
