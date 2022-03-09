<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class AlignObjectiveRequest extends Model
{
    /**
     * @description 周期 ID
     *
     * @var string
     */
    public $periodId;

    /**
     * @description 对齐目标的 ID
     *
     * @var string
     */
    public $targetId;

    /**
     * @description 用户 ID
     *
     * @var Stream
     */
    public $ownerId;
    protected $_name = [
        'periodId' => 'periodId',
        'targetId' => 'targetId',
        'ownerId'  => 'ownerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->targetId) {
            $res['targetId'] = $this->targetId;
        }
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AlignObjectiveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['targetId'])) {
            $model->targetId = $map['targetId'];
        }
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }

        return $model;
    }
}
