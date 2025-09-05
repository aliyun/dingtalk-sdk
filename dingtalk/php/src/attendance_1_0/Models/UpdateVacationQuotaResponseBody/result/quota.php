<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateVacationQuotaResponseBody\result;

use AlibabaCloud\Tea\Model;

class quota extends Model
{
    /**
     * @example f84a2829-d245-4312-9ff2-0653e5b3abb2
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @example 2019
     *
     * @var string
     */
    public $quotaCycle;

    /**
     * @example user01
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'leaveCode' => 'leaveCode',
        'quotaCycle' => 'quotaCycle',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->quotaCycle) {
            $res['quotaCycle'] = $this->quotaCycle;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return quota
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['quotaCycle'])) {
            $model->quotaCycle = $map['quotaCycle'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
