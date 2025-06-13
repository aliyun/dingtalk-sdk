<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class IsOrgMicroAppVisibleByUserIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $appId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'appId' => 'appId',
        'id' => 'id',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
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
     * @return IsOrgMicroAppVisibleByUserIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
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
