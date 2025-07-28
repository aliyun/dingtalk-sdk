<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalKeyResultDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalKeyActionDTO[]
     */
    public $keyActions;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $keyResultId;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $progress;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 测试KR
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @var TitleMention[]
     */
    public $titleMentions;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @example 30
     *
     * @var float
     */
    public $weight;
    protected $_name = [
        'keyActions' => 'keyActions',
        'keyResultId' => 'keyResultId',
        'progress' => 'progress',
        'status' => 'status',
        'title' => 'title',
        'titleMentions' => 'titleMentions',
        'type' => 'type',
        'weight' => 'weight',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyActions) {
            $res['keyActions'] = [];
            if (null !== $this->keyActions && \is_array($this->keyActions)) {
                $n = 0;
                foreach ($this->keyActions as $item) {
                    $res['keyActions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->keyResultId) {
            $res['keyResultId'] = $this->keyResultId;
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
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalKeyResultDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyActions'])) {
            if (!empty($map['keyActions'])) {
                $model->keyActions = [];
                $n = 0;
                foreach ($map['keyActions'] as $item) {
                    $model->keyActions[$n++] = null !== $item ? OpenAgoalKeyActionDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['keyResultId'])) {
            $model->keyResultId = $map['keyResultId'];
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
                $n = 0;
                foreach ($map['titleMentions'] as $item) {
                    $model->titleMentions[$n++] = null !== $item ? TitleMention::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }

        return $model;
    }
}
