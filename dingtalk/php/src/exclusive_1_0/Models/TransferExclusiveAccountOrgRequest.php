<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class TransferExclusiveAccountOrgRequest extends Model
{
    /**
     * @var bool
     */
    public $isSettingMainOrg;

    /**
     * @var string
     */
    public $targetCorpId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'isSettingMainOrg' => 'isSettingMainOrg',
        'targetCorpId'     => 'targetCorpId',
        'userIds'          => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isSettingMainOrg) {
            $res['isSettingMainOrg'] = $this->isSettingMainOrg;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TransferExclusiveAccountOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isSettingMainOrg'])) {
            $model->isSettingMainOrg = $map['isSettingMainOrg'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
