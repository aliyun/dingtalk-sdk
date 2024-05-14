<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListResidentUserInfosShrinkRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userIdsShrink;
    protected $_name = [
        'subCorpId'     => 'subCorpId',
        'userIdsShrink' => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->userIdsShrink) {
            $res['userIds'] = $this->userIdsShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListResidentUserInfosShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['userIds'])) {
            $model->userIdsShrink = $map['userIds'];
        }

        return $model;
    }
}
