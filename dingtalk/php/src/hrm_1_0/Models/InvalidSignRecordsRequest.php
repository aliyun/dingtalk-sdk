<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvalidSignRecordsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $invalidUserId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $signRecordIds;

    /**
     * @description This parameter is required.
     *
     * @example 作废测试
     *
     * @var string
     */
    public $statusRemark;
    protected $_name = [
        'invalidUserId' => 'invalidUserId',
        'signRecordIds' => 'signRecordIds',
        'statusRemark'  => 'statusRemark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invalidUserId) {
            $res['invalidUserId'] = $this->invalidUserId;
        }
        if (null !== $this->signRecordIds) {
            $res['signRecordIds'] = $this->signRecordIds;
        }
        if (null !== $this->statusRemark) {
            $res['statusRemark'] = $this->statusRemark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InvalidSignRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invalidUserId'])) {
            $model->invalidUserId = $map['invalidUserId'];
        }
        if (isset($map['signRecordIds'])) {
            if (!empty($map['signRecordIds'])) {
                $model->signRecordIds = $map['signRecordIds'];
            }
        }
        if (isset($map['statusRemark'])) {
            $model->statusRemark = $map['statusRemark'];
        }

        return $model;
    }
}
