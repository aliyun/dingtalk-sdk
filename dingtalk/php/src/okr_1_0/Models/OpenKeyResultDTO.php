<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenKeyResultDTO extends Model
{
    /**
     * @example 65222713d0e8b868f9f9ae51
     *
     * @var string
     */
    public $krId;

    /**
     * @example 80
     *
     * @var int
     */
    public $progress;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 这是一个KR
     *
     * @var string
     */
    public $title;

    /**
     * @var TitleMention[]
     */
    public $titleMentions;

    /**
     * @example 1
     *
     * @var int
     */
    public $type;

    /**
     * @example 10.00
     *
     * @var float
     */
    public $weight;
    protected $_name = [
        'krId'          => 'krId',
        'progress'      => 'progress',
        'status'        => 'status',
        'title'         => 'title',
        'titleMentions' => 'titleMentions',
        'type'          => 'type',
        'weight'        => 'weight',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->krId) {
            $res['krId'] = $this->krId;
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
     * @return OpenKeyResultDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['krId'])) {
            $model->krId = $map['krId'];
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
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }

        return $model;
    }
}
