<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeMainOrgRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example corpIdCCC
     *
     * @var string
     */
    public $newMainCorpId;

    /**
     * @description This parameter is required.
     *
     * @example userIdAA
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'newMainCorpId' => 'newMainCorpId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->newMainCorpId) {
            $res['newMainCorpId'] = $this->newMainCorpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChangeMainOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newMainCorpId'])) {
            $model->newMainCorpId = $map['newMainCorpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
