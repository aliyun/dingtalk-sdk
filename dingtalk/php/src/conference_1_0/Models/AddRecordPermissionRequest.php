<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddRecordPermissionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cloud_record
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFFXXXXXXX
     *
     * @var string
     */
    public $ownerUnionId;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bizType'      => 'bizType',
        'ownerUnionId' => 'ownerUnionId',
        'unionId'      => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->ownerUnionId) {
            $res['ownerUnionId'] = $this->ownerUnionId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRecordPermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['ownerUnionId'])) {
            $model->ownerUnionId = $map['ownerUnionId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
