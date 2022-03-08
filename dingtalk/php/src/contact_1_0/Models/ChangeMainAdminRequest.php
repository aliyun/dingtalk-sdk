<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeMainAdminRequest extends Model
{
    /**
     * @description effectCorpId
     *
     * @var string
     */
    public $effectCorpId;

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
    protected $_name = [
        'effectCorpId' => 'effectCorpId',
        'sourceUserId' => 'sourceUserId',
        'targetUserId' => 'targetUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->effectCorpId) {
            $res['effectCorpId'] = $this->effectCorpId;
        }
        if (null !== $this->sourceUserId) {
            $res['sourceUserId'] = $this->sourceUserId;
        }
        if (null !== $this->targetUserId) {
            $res['targetUserId'] = $this->targetUserId;
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
        if (isset($map['effectCorpId'])) {
            $model->effectCorpId = $map['effectCorpId'];
        }
        if (isset($map['sourceUserId'])) {
            $model->sourceUserId = $map['sourceUserId'];
        }
        if (isset($map['targetUserId'])) {
            $model->targetUserId = $map['targetUserId'];
        }

        return $model;
    }
}
