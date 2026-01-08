<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainLabelTaskMetaRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $optWorkNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sessionId;
    protected $_name = [
        'optWorkNo' => 'optWorkNo',
        'sessionId' => 'sessionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->optWorkNo) {
            $res['optWorkNo'] = $this->optWorkNo;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainLabelTaskMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['optWorkNo'])) {
            $model->optWorkNo = $map['optWorkNo'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }

        return $model;
    }
}
