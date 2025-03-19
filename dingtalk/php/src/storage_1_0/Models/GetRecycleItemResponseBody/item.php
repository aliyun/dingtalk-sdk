<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleItemResponseBody;

use AlibabaCloud\Tea\Model;

class item extends Model
{
    /**
     * @example dentry_id
     *
     * @var string
     */
    public $dentryId;

    /**
     * @example recycle_item_id
     *
     * @var string
     */
    public $id;

    /**
     * @example operator_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $operatorTime;

    /**
     * @example dentry_name
     *
     * @var string
     */
    public $originalName;

    /**
     * @example dentry_path
     *
     * @var string
     */
    public $originalPath;

    /**
     * @example 512
     *
     * @var int
     */
    public $size;

    /**
     * @example space_id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example file
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'dentryId' => 'dentryId',
        'id' => 'id',
        'operatorId' => 'operatorId',
        'operatorTime' => 'operatorTime',
        'originalName' => 'originalName',
        'originalPath' => 'originalPath',
        'size' => 'size',
        'spaceId' => 'spaceId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->operatorTime) {
            $res['operatorTime'] = $this->operatorTime;
        }
        if (null !== $this->originalName) {
            $res['originalName'] = $this->originalName;
        }
        if (null !== $this->originalPath) {
            $res['originalPath'] = $this->originalPath;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return item
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['operatorTime'])) {
            $model->operatorTime = $map['operatorTime'];
        }
        if (isset($map['originalName'])) {
            $model->originalName = $map['originalName'];
        }
        if (isset($map['originalPath'])) {
            $model->originalPath = $map['originalPath'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
