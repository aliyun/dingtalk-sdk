<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreNodeInfoResponseBody extends Model
{
    /**
     * @description 节点Id
     *
     * @var int
     */
    public $id;

    /**
     * @description 门店名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 上级节点id
     *
     * @var int
     */
    public $parentId;

    /**
     * @description 节点类型
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'id'       => 'id',
        'name'     => 'name',
        'parentId' => 'parentId',
        'type'     => 'type',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreNodeInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
