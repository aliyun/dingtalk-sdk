<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeMainAdminRequest extends Model
{
    /**
     * @description sourceUserId
     *
     * @var string
     */
    public $sourceUserId;

    /**
     * @description targetUserId
     *
     * @var string
     */
    public $targetUserId;

    /**
     * @description effectCorpId
     *
     * @var string
     */
    public $effectCorpId;
    protected $_name = [
        'sourceUserId' => 'sourceUserId',
        'targetUserId' => 'targetUserId',
        'effectCorpId' => 'effectCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sourceUserId) {
            $res['sourceUserId'] = $this->sourceUserId;
        }
        if (null !== $this->targetUserId) {
            $res['targetUserId'] = $this->targetUserId;
        }
        if (null !== $this->effectCorpId) {
            $res['effectCorpId'] = $this->effectCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChangeMainAdminRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sourceUserId'])) {
            $model->sourceUserId = $map['sourceUserId'];
        }
        if (isset($map['targetUserId'])) {
            $model->targetUserId = $map['targetUserId'];
        }
        if (isset($map['effectCorpId'])) {
            $model->effectCorpId = $map['effectCorpId'];
        }

        return $model;
    }
}
