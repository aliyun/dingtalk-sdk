<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\AddPermissionRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @example corp_id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example member_id
     *
     * @var string
     */
    public $id;

    /**
     * @example member_name
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example USER
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'corpId' => 'corpId',
        'id' => 'id',
        'name' => 'name',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return members
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
