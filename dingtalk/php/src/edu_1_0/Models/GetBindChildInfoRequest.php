<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetBindChildInfoRequest extends Model
{
    /**
     * @example ding95eef8003c9ca8ca24f2f5cc6abecb85
     *
     * @var string
     */
    public $schoolCorpId;

    /**
     * @example 3000000000307711730
     *
     * @var string
     */
    public $studentUserId;

    /**
     * @example X5y5kd8XiiqiScCl4Qlfy5GgiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'schoolCorpId'  => 'schoolCorpId',
        'studentUserId' => 'studentUserId',
        'unionId'       => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->schoolCorpId) {
            $res['schoolCorpId'] = $this->schoolCorpId;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBindChildInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['schoolCorpId'])) {
            $model->schoolCorpId = $map['schoolCorpId'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
