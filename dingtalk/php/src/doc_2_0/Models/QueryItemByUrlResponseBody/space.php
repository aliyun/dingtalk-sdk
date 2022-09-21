<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlResponseBody\space\owner;
use AlibabaCloud\Tea\Model;

class space extends Model
{
    /**
     * @description 知识库简介。
     *
     * @var string
     */
    public $description;

    /**
     * @description 知识库id。
     *
     * @var string
     */
    public $id;

    /**
     * @description 知识库名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 如果type=2，会返回其所有者。
     *
     * @var owner
     */
    public $owner;

    /**
     * @description 知识库类型。1-知识库；2-我的文档。
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'description' => 'description',
        'id'          => 'id',
        'name'        => 'name',
        'owner'       => 'owner',
        'type'        => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->owner) {
            $res['owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return space
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['owner'])) {
            $model->owner = owner::fromMap($map['owner']);
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
