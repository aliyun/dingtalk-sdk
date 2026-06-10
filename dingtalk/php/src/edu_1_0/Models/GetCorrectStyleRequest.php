<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCorrectStyleRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding123...
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example ding_scan_correct_...
     *
     * @var string
     */
    public $taskCode;
    protected $_name = [
        'corpId' => 'corpId',
        'taskCode' => 'taskCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCorrectStyleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }

        return $model;
    }
}
