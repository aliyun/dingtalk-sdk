<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetBindChildInfoRequest extends Model
{
    /**
     * @description 学校id
     *
     * @var string
     */
    public $schoolCorpId;

    /**
     * @description 学生id
     *
     * @var string
     */
    public $studentUserId;

    /**
     * @description 当前操作人唯一id
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
