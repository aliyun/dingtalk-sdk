<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TalentQueryTagLikeDetailListResponseBody\result;

use AlibabaCloud\Tea\Model;

class likeDetails extends Model
{
    /**
     * @var int
     */
    public $likeTimestamp;

    /**
     * @var string
     */
    public $operatorUserId;
    protected $_name = [
        'likeTimestamp' => 'likeTimestamp',
        'operatorUserId' => 'operatorUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->likeTimestamp) {
            $res['likeTimestamp'] = $this->likeTimestamp;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return likeDetails
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['likeTimestamp'])) {
            $model->likeTimestamp = $map['likeTimestamp'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }

        return $model;
    }
}
