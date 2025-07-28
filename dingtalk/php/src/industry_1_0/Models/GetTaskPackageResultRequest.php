<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTaskPackageResultRequest extends Model
{
    /**
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $taskPackageId;
    protected $_name = [
        'bizCode' => 'bizCode',
        'taskPackageId' => 'taskPackageId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->taskPackageId) {
            $res['taskPackageId'] = $this->taskPackageId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskPackageResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['taskPackageId'])) {
            $model->taskPackageId = $map['taskPackageId'];
        }

        return $model;
    }
}
