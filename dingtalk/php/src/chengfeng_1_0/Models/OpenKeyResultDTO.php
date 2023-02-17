<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenKeyResultDTO extends Model
{
    /**
     * @description 主键
     *
     * @var string
     */
    public $id;

    /**
     * @description KR进度
     *
     * @var int
     */
    public $progress;

    /**
     * @description KR的状态:1:正常 3:风险
     *
     * @var int
     */
    public $status;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description “@”对象列表
     *
     * @var TitleMention[]
     */
    public $titleMentions;

    /**
     * @description KR类型
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'id'            => 'id',
        'progress'      => 'progress',
        'status'        => 'status',
        'title'         => 'title',
        'titleMentions' => 'titleMentions',
        'type'          => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->progress) {
            $res['progress'] = $this->progress;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->titleMentions) {
            $res['titleMentions'] = [];
            if (null !== $this->titleMentions && \is_array($this->titleMentions)) {
                $n = 0;
                foreach ($this->titleMentions as $item) {
                    $res['titleMentions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenKeyResultDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['progress'])) {
            $model->progress = $map['progress'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['titleMentions'])) {
            if (!empty($map['titleMentions'])) {
                $model->titleMentions = [];
                $n                    = 0;
                foreach ($map['titleMentions'] as $item) {
                    $model->titleMentions[$n++] = null !== $item ? TitleMention::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
