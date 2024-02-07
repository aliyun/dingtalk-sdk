<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $ownerId;

    /**
     * @var string
     */
    public $pointType;
    protected $_name = [
        'bizId'     => 'bizId',
        'ownerId'   => 'ownerId',
        'pointType' => 'pointType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }
        if (null !== $this->pointType) {
            $res['pointType'] = $this->pointType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }
        if (isset($map['pointType'])) {
            $model->pointType = $map['pointType'];
        }

        return $model;
    }
}
