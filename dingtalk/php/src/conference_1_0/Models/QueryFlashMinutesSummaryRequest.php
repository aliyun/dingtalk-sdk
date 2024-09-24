<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryFlashMinutesSummaryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cloud_record
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRG9KXXXX
     *
     * @var string
     */
    public $recorderUnionId;
    protected $_name = [
        'bizType'         => 'bizType',
        'recorderUnionId' => 'recorderUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->recorderUnionId) {
            $res['recorderUnionId'] = $this->recorderUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFlashMinutesSummaryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['recorderUnionId'])) {
            $model->recorderUnionId = $map['recorderUnionId'];
        }

        return $model;
    }
}
