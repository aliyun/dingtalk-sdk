<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ManagementModifySpaceRequest extends Model
{
    /**
     * @description 容量
     *
     * @var int
     */
    public $quota;

    /**
     * @description 空间id列表
     *
     * @var string[]
     */
    public $spaceIds;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'quota'    => 'quota',
        'spaceIds' => 'spaceIds',
        'unionId'  => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }
        if (null !== $this->spaceIds) {
            $res['spaceIds'] = $this->spaceIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ManagementModifySpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }
        if (isset($map['spaceIds'])) {
            if (!empty($map['spaceIds'])) {
                $model->spaceIds = $map['spaceIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
