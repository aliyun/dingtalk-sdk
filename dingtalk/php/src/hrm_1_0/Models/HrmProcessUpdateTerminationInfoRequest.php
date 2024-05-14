<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmProcessUpdateTerminationInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 因个人原因离职
     *
     * @var string
     */
    public $dismissionMemo;

    /**
     * @description This parameter is required.
     *
     * @example 1672502400000
     *
     * @var int
     */
    public $lastWorkDate;

    /**
     * @description This parameter is required.
     *
     * @example admin123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dismissionMemo' => 'dismissionMemo',
        'lastWorkDate'   => 'lastWorkDate',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dismissionMemo) {
            $res['dismissionMemo'] = $this->dismissionMemo;
        }
        if (null !== $this->lastWorkDate) {
            $res['lastWorkDate'] = $this->lastWorkDate;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmProcessUpdateTerminationInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dismissionMemo'])) {
            $model->dismissionMemo = $map['dismissionMemo'];
        }
        if (isset($map['lastWorkDate'])) {
            $model->lastWorkDate = $map['lastWorkDate'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
