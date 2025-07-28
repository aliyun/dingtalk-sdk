<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFileStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $requestIds;

    /**
     * @description This parameter is required.
     *
     * @example 1-检测通过，2-检测失败
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'requestIds' => 'requestIds',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestIds) {
            $res['requestIds'] = $this->requestIds;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFileStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestIds'])) {
            if (!empty($map['requestIds'])) {
                $model->requestIds = $map['requestIds'];
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
