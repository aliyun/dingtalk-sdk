<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainTalentSearchResultRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sessionId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'sessionId' => 'sessionId',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainTalentSearchResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
