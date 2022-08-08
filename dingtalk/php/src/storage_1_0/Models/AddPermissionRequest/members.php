<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddPermissionRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description 权限归属的企业
     * 如果memberType是dept类型，必须要有企业id
     * @var string
     */
    public $corpId;

    /**
     * @description 权限成员id
     *
     * @var string
     */
    public $id;

    /**
     * @description 权限成员类型
     * ALL_USERS: 所有用户
     * @var string
     */
    public $type;
    protected $_name = [
        'corpId' => 'corpId',
        'id'     => 'id',
        'type'   => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
