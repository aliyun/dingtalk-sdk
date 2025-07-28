<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ManagementModifySpaceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $quota;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $spaceIds;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'quota' => 'quota',
        'spaceIds' => 'spaceIds',
        'unionId' => 'unionId',
    ];

    public function validate() {}

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
