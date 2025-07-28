<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\Entity\children;
use AlibabaCloud\Tea\Model;

class Entity extends Model
{
    /**
     * @var children[]
     */
    public $children;

    /**
     * @example {"title": "123"}
     *
     * @var mixed[]
     */
    public $data;

    /**
     * @example 123
     *
     * @var string
     */
    public $id;

    /**
     * @example y/n
     *
     * @var string
     */
    public $isDeleted;

    /**
     * @example 67dbb24f7aac3f62d8b98fb5
     *
     * @var string
     */
    public $linkSourceId;

    /**
     * @example EXTERNAL_PERF_TASK
     *
     * @var string
     */
    public $linkSourceType;

    /**
     * @var Meta[]
     */
    public $metas;

    /**
     * @example DIMENSION
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'children' => 'children',
        'data' => 'data',
        'id' => 'id',
        'isDeleted' => 'isDeleted',
        'linkSourceId' => 'linkSourceId',
        'linkSourceType' => 'linkSourceType',
        'metas' => 'metas',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->children) {
            $res['children'] = [];
            if (null !== $this->children && \is_array($this->children)) {
                $n = 0;
                foreach ($this->children as $item) {
                    $res['children'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->linkSourceId) {
            $res['linkSourceId'] = $this->linkSourceId;
        }
        if (null !== $this->linkSourceType) {
            $res['linkSourceType'] = $this->linkSourceType;
        }
        if (null !== $this->metas) {
            $res['metas'] = [];
            if (null !== $this->metas && \is_array($this->metas)) {
                $n = 0;
                foreach ($this->metas as $item) {
                    $res['metas'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return Entity
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = [];
                $n = 0;
                foreach ($map['children'] as $item) {
                    $model->children[$n++] = null !== $item ? children::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['linkSourceId'])) {
            $model->linkSourceId = $map['linkSourceId'];
        }
        if (isset($map['linkSourceType'])) {
            $model->linkSourceType = $map['linkSourceType'];
        }
        if (isset($map['metas'])) {
            if (!empty($map['metas'])) {
                $model->metas = [];
                $n = 0;
                foreach ($map['metas'] as $item) {
                    $model->metas[$n++] = null !== $item ? Meta::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
