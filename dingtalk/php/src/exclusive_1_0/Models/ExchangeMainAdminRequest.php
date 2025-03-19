<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExchangeMainAdminRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 509999
     *
     * @var string
     */
    public $newAdminUserId;

    /**
     * @description This parameter is required.
     *
     * @example 4045678
     *
     * @var string
     */
    public $oldAdminUserId;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxxxxxxxxxx
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'newAdminUserId' => 'newAdminUserId',
        'oldAdminUserId' => 'oldAdminUserId',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->newAdminUserId) {
            $res['newAdminUserId'] = $this->newAdminUserId;
        }
        if (null !== $this->oldAdminUserId) {
            $res['oldAdminUserId'] = $this->oldAdminUserId;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExchangeMainAdminRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newAdminUserId'])) {
            $model->newAdminUserId = $map['newAdminUserId'];
        }
        if (isset($map['oldAdminUserId'])) {
            $model->oldAdminUserId = $map['oldAdminUserId'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
