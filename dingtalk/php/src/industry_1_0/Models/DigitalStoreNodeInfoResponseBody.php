<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreNodeInfoResponseBody extends Model
{
    /**
     * @example 76644111
     *
     * @var int
     */
    public $dingDeptId;

    /**
     * @description This parameter is required.
     *
     * @example 6756433
     *
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 华夏之心店
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 873366531
     *
     * @var int
     */
    public $parentId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'dingDeptId' => 'dingDeptId',
        'id' => 'id',
        'name' => 'name',
        'parentId' => 'parentId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingDeptId) {
            $res['dingDeptId'] = $this->dingDeptId;
        }
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
        if (isset($map['dingDeptId'])) {
            $model->dingDeptId = $map['dingDeptId'];
        }
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
