<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class RevokeSignRecordsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 12345
     *
     * @var string
     */
    public $revokeUserId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $signRecordIds;

    /**
     * @description This parameter is required.
     *
     * @example 撤销签署
     *
     * @var string
     */
    public $statusRemark;
    protected $_name = [
        'revokeUserId'  => 'revokeUserId',
        'signRecordIds' => 'signRecordIds',
        'statusRemark'  => 'statusRemark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->revokeUserId) {
            $res['revokeUserId'] = $this->revokeUserId;
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
     * @return RevokeSignRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['revokeUserId'])) {
            $model->revokeUserId = $map['revokeUserId'];
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
